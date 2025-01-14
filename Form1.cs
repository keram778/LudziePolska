using LudziePolska.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            LoadProffesions();
            LoadKolorSkory();
            LoadWojewodztwa();
            LoadPeopleFromBase();
        }
        private void LoadWojewodztwa()
        {
            provinces.Clear();
            provinces = BaseQuerries.Querries.GetProvinces();
        }
        private void LoadKolorSkory()
        {
            skinColors.Clear();
            skinColors = BaseQuerries.Querries.GetSkinColors();
            skinColorCombo.Items.Clear();
            skinColorCombo.Items.Add("Wszystkie");
            foreach (string color in skinColors)
            {
                skinColorCombo.Items.Add(color);
            }
            skinColorCombo.SelectedIndex = 0;
        }
        private void LoadProffesions()
        {
            proffesions.Clear();
            proffesions = BaseQuerries.Querries.GetProffesions();
            proffessionCombo.Items.Clear();
            proffessionCombo.Items.Add("Wszystkie");
            foreach (string proffesion in proffesions)
            {
                proffessionCombo.Items.Add(proffesion);
            }
            proffessionCombo.SelectedIndex = 0;
        }
        private void LoadPeopleFromBase()
        {
            people.Clear();
            people = BaseQuerries.Querries.GetPoeple();
            peopleDGV.DataSource = people;
            noOfRecordsLbl.Text = $"Ilość rekordów: {people.Count}";
            //make datagridview columns readonly
            foreach (DataGridViewColumn column in peopleDGV.Columns)
                column.ReadOnly = true;
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
            LoadPeopleFromBase();
            FilterList();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (peopleDGV.SelectedRows.Count <= 0)
                return;

            if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone wiersze?", "Pyanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            BaseQuerries.Querries.DeleteSelected(peopleDGV.SelectedRows);
            LoadPeopleFromBase();
            FilterList();
        }
        private void showLogFile_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("log.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas otwierania pliku logu." + Environment.NewLine + ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void exportProvinceBtn_Click(object sender, EventArgs e)
        {
            ExportProvinceForm exportProvinceForm = new ExportProvinceForm(provinces, people);
            exportProvinceForm.ShowDialog();
        }
        private void exportSelectedBtn_Click(object sender, EventArgs e)
        {
            if (peopleDGV.SelectedRows.Count <= 0)
                return;

            buttonsPanel.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            List<Person> selectedPerson = new List<Person>();

            foreach (DataGridViewRow row in peopleDGV.SelectedRows)
            {
                selectedPerson.Add(new Person
                {
                    ID_Osoby = Convert.ToInt32(row.Cells[0].Value.ToString()),
                    Imie = row.Cells[1].Value.ToString(),
                    Nazwisko = row.Cells[2].Value.ToString(),
                    Pesel = row.Cells[3].Value.ToString(),
                    DataUrodzenia = Convert.ToDateTime(row.Cells[4].Value.ToString()),
                    KolorSkory = row.Cells[5].Value.ToString(),
                    NazwaWojewodztwa = row.Cells[6].Value.ToString(),
                    Zawod = row.Cells[7].Value.ToString(),
                });
            }

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add();
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Imię";
            xlWorkSheet.Cells[1, 3] = "Nazwisko";
            xlWorkSheet.Cells[1, 4] = "Pesel";
            xlWorkSheet.Cells[1, 5] = "Data ur.";
            xlWorkSheet.Cells[1, 6] = "Kolor skóry";
            xlWorkSheet.Cells[1, 7] = "Województwo";
            xlWorkSheet.Cells[1, 8] = "Zawód";

            int rowIndex = 2;
            foreach (Person person in selectedPerson)
            {
                xlWorkSheet.Cells[rowIndex, 1] = person.ID_Osoby.ToString();
                xlWorkSheet.Cells[rowIndex, 2] = person.Imie;
                xlWorkSheet.Cells[rowIndex, 3] = person.Nazwisko;
                xlWorkSheet.Cells[rowIndex, 4] = "'" + person.Pesel;
                xlWorkSheet.Cells[rowIndex, 5] = person.DataUrodzenia.ToShortDateString();
                xlWorkSheet.Cells[rowIndex, 6] = person.KolorSkory;
                xlWorkSheet.Cells[rowIndex, 7] = person.NazwaWojewodztwa.ToString();
                xlWorkSheet.Cells[rowIndex, 8] = person.Zawod;
                rowIndex++;
            }
            xlApp.Visible = true;
            Cursor.Current = Cursors.Arrow;
            buttonsPanel.Enabled = true;
        }
    }
}
