using LudziePolska.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LudziePolska
{
    public partial class AddPersonForm : Form
    {
        readonly List<Province> provinces = new List<Province>();
        public AddPersonForm(List<string> skinColors, List<string> proffesions, List<Province> provinces)
        {
            InitializeComponent();
            this.provinces = provinces;

            //dodaj dane do comboboxów
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

            Person person = new Person
            {
                Imie = firstNameTxt.Text,
                Nazwisko = nameTxt.Text,
                Pesel = peselTxt.Text,
                DataUrodzenia = birthDatePicker.Value.Date,
                KolorSkory = skinColorCombo.Text,
                Zawod = proffessionCombo.Text,
                ID_Wojewodztwo = Convert.ToInt32(provinces[provinceCombo.SelectedIndex].ID_Wojewodztwa)
            };

            //wstaw dane do bazy danych
            BaseQuerries.Querries.InsertPerson(person);
            this.Close();
        }
        private bool HasErrors()
        {
            //sprawdź długość numeru pesel
            if (peselTxt.Text.Length != 11)
            {
                MessageBox.Show("Wprowadź prawidłową długość numeru pesel.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //sprawdź czy numer pesel jest liczbą
            if (!double.TryParse(peselTxt.Text, out _))
            {
                MessageBox.Show("Numer pesel nie jest prawidłową liczbą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //sprawdź czy wypełniono pole imienia
            if (string.IsNullOrWhiteSpace(firstNameTxt.Text))
            {
                MessageBox.Show("Uzupełnij pole imienia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //sprawdź czy pierwsza litera imienia jest wielka
            Char firstLetter = Convert.ToChar(firstNameTxt.Text.Substring(0, 1));
            if (!char.IsUpper(firstLetter))
            {
                MessageBox.Show("Imię musi zaczynać się od wielkiej litery.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //sprawdź czy wypełniono pole nazwiska
            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                MessageBox.Show("Uzupełnij pole nazwiska.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //sprawdź czy pierwsza litera nazwiska jest wielka
            firstLetter = Convert.ToChar(nameTxt.Text.Substring(0, 1));
            if (!char.IsUpper(firstLetter))
            {
                MessageBox.Show("Nazwisko musi zaczynać się od wielkiej litery.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //sprawdź czy wybrano zawód
            if (proffessionCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Nie wybrano zawodu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //sprawdź czy wybrano kolor skóry
            if (skinColorCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Nie wybrano koloru skóry.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //sprawdź czy wybrano województwo
            if (provinceCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Nie wybrano województwa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }
}
