using LudziePolska.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LudziePolska
{
    public partial class Form1 : Form
    {
        List<Person> people;
        List<Person> peopleSorted;
        List<Province> provinces;
        List<string> skinColors;
        List<string> proffesions;
        public Form1()
        {
            InitializeComponent();
            ExtensionMethods.EnableDoubleBuffered(peopleDGV);
            people = new List<Person>();
            peopleSorted = new List<Person>();
            provinces = new List<Province>();
            skinColors = new List<string>();
            proffesions = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVars.GetConnectionString());
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadZawody(con);
            LoadKolorSkory(con);
            LoadWojewodztwa(con);
            LoadPeopleFromBase(con);
        }

        private void LoadWojewodztwa(SqlConnection con)
        {
            string querry = "select * from wojewodztwa order by id_wojewodztwa";
            SqlCommand command = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            //copy data to list of person
            foreach (DataRow row in dt.Rows)
            {
                provinces.Add(new Province
                {
                    ID_Wojewodztwa = Convert.ToInt32(row["ID_Wojewodztwa"]),
                    ProvinceName = row["NazwaWojewodztwa"].ToString(),
                });
            }
        }

        private void LoadKolorSkory(SqlConnection con)
        {
            skinColorCombo.Items.Clear();
            string querry = "select distinct kolorskory from osoby";
            SqlCommand command = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            skinColorCombo.Items.Add("Wszystkie");
            //copy data to list of person
            foreach (DataRow row in dt.Rows)
            {
                skinColors.Add(row[0].ToString());
                skinColorCombo.Items.Add(row[0].ToString());
            }
            skinColorCombo.SelectedIndex = 0;
            ExtensionMethods.LogTransaction(querry);
        }
        private void LoadZawody(SqlConnection con)
        {
            proffessionCombo.Items.Clear();
            string querry = "select distinct zawod from osoby";
            SqlCommand command = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            proffessionCombo.Items.Add("Wszystkie");
            //copy data to list of person
            foreach (DataRow row in dt.Rows)
            {
                proffesions.Add(row[0].ToString());
                proffessionCombo.Items.Add(row[0].ToString());
            }
            proffessionCombo.SelectedIndex = 0;
            ExtensionMethods.LogTransaction(querry);
        }

        private void LoadPeopleFromBase(SqlConnection con)
        {
            //read data from database
            string querry = "SELECT ID_Osoby,Imie, Nazwisko, PESEL, DataUrodzenia, KolorSkory, Wojewodztwa.NazwaWojewodztwa, Zawod FROM Osoby INNER JOIN Wojewodztwa ON Osoby.ID_Wojewodztwa = Wojewodztwa.ID_Wojewodztwa";
            SqlCommand command = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            //copy data to list of person
            foreach (DataRow row in dt.Rows)
            {
                people.Add(new Person
                {
                    ID_Osoby = Convert.ToInt32(row["ID_Osoby"]),
                    Imie = row["Imie"].ToString(),
                    Nazwisko = row["Nazwisko"].ToString(),
                    Pesel = row["PESEL"].ToString(),
                    DataUrodzenia = Convert.ToDateTime(row["DataUrodzenia"]),
                    KolorSkory = row["KolorSkory"].ToString(),
                    NazwaWojewodztwa = row["NazwaWojewodztwa"].ToString(),
                    Zawod = row["Zawod"].ToString(),
                });
            }
            peopleDGV.DataSource = people;

            noOfRecordsLbl.Text = $"Ilość rekordów: {people.Count}";

            //make datagridview columns readonly
            foreach (DataGridViewColumn column in peopleDGV.Columns)
                column.ReadOnly = true;

            ExtensionMethods.LogTransaction(querry);
        }

        private void proffessionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        private void skinColorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        private void dateFromPicker_ValueChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        private void dateToPicker_ValueChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        private void peselTxt_TextChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        private void FilterList()
        {
            List<Person> peopleFiltered = new List<Person>();
            foreach (Person person in people)
            {
                if (string.IsNullOrWhiteSpace(peselTxt.Text) || person.Pesel.Contains(peselTxt.Text))
                {
                    if (string.IsNullOrWhiteSpace(provinceTxt.Text) || person.NazwaWojewodztwa.ToLower().Contains(provinceTxt.Text.ToLower()))
                    {
                        if (string.IsNullOrWhiteSpace(nameTxt.Text) || person.Nazwisko.ToLower().Contains(nameTxt.Text.ToLower()))
                        {
                            if (proffessionCombo.SelectedIndex == 0 || person.Zawod == proffessionCombo.Text)
                            {
                                if (skinColorCombo.SelectedIndex == 0 || person.KolorSkory == skinColorCombo.Text)
                                {
                                    if (person.DataUrodzenia >= dateFromPicker.Value && person.DataUrodzenia <= dateToPicker.Value)
                                        peopleFiltered.Add(person);
                                }
                            }
                        }
                    }
                }
            }
            peopleDGV.DataSource = peopleFiltered;
            noOfRecordsLbl.Text = $"Ilość rekordów: {peopleFiltered.Count}";
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        private void provinceTxt_TextChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        private void removeFiltersBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Text = string.Empty;
            provinceTxt.Text = string.Empty;
            peselTxt.Text = string.Empty;
            proffessionCombo.SelectedIndex = 0;
            skinColorCombo.SelectedIndex = 0;
            dateFromPicker.Value = new DateTime(1920, 1, 1);
            dateToPicker.Value = DateTime.Today;
            FilterList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm(skinColors, proffesions, provinces);
            addPersonForm.ShowDialog();
            SqlConnection con = new SqlConnection(GlobalVars.GetConnectionString());
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            people.Clear();
            LoadPeopleFromBase(con);
            FilterList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (peopleDGV.SelectedRows.Count <= 0)
                return;

            if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone wiersze?", "Pyanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            SqlConnection con = new SqlConnection(GlobalVars.GetConnectionString());
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in peopleDGV.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                string querry = "delete from osoby where id_osoby=@id";
                SqlCommand command = new SqlCommand(querry, con);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                ExtensionMethods.LogTransaction(querry);
            }
            people.Clear();
            LoadPeopleFromBase(con);
        }
    }
}
