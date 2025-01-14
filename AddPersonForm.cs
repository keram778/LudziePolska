using LudziePolska.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LudziePolska
{
    public partial class AddPersonForm : Form
    {
        readonly List<string> skinColors = new List<string>();
        readonly List<string> proffesions = new List<string>();
        readonly List<Province> provinces = new List<Province>();

        public AddPersonForm(List<string> skinColors, List<string> proffesions, List<Province> provinces)
        {
            InitializeComponent();
            this.skinColors = skinColors;
            this.proffesions = proffesions;
            this.provinces = provinces;

            foreach (Province province in provinces)
                provinceCombo.Items.Add(province.ProvinceName);

            foreach (string skinColor in skinColors)
                skinColorCombo.Items.Add(skinColor);

            foreach (string proffesion in proffesions)
                proffessionCombo.Items.Add(proffesion);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (HasErrors())
                return;

            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string querry = "insert into osoby (imie, nazwisko, pesel, dataurodzenia, kolorskory, id_wojewodztwa, zawod) values ";
            querry += "(@imie, @nazwisko, @pesel, @dataurodzenia, @kolorskory, @id_wojewodztwa, @zawod)";
            SqlCommand command = new SqlCommand(querry, con);
            command.Parameters.AddWithValue("@imie", firstNameTxt.Text);
            command.Parameters.AddWithValue("@nazwisko", nameTxt.Text);
            command.Parameters.AddWithValue("@pesel", peselTxt.Text);
            command.Parameters.AddWithValue("@dataurodzenia", birthDatePicker.Value.Date);
            command.Parameters.AddWithValue("@kolorskory", skinColorCombo.Text);
            command.Parameters.AddWithValue("@id_wojewodztwa", Convert.ToInt32(provinces[provinceCombo.SelectedIndex].ID_Wojewodztwa));
            command.Parameters.AddWithValue("@zawod", proffessionCombo.Text);
            command.ExecuteNonQuery();
            ExtensionMethods.LogTransaction(querry);

            this.Close();
        }

        private bool HasErrors()
        {
            if (peselTxt.Text.Length != 11)
            {
                MessageBox.Show("Wprowadź prawidłową długość numeru pesel.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (!double.TryParse(peselTxt.Text, out _))
            {
                MessageBox.Show("Numer pesel nie jest prawidłową liczbą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (string.IsNullOrWhiteSpace(firstNameTxt.Text))
            {
                MessageBox.Show("Uzupełnij pole imienia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            Char firstLetter = Convert.ToChar(firstNameTxt.Text.Substring(0, 1));
            if (!char.IsUpper(firstLetter))
            {
                MessageBox.Show("Imię musi zaczynać się od wielkiej litery.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                MessageBox.Show("Uzupełnij pole nazwiska.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            firstLetter = Convert.ToChar(nameTxt.Text.Substring(0, 1));
            if (!char.IsUpper(firstLetter))
            {
                MessageBox.Show("Nazwisko musi zaczynać się od wielkiej litery.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (proffessionCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Nie wybrano zawodu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (skinColorCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Nie wybrano koloru skóry.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (provinceCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Nie wybrano województwa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }
}
