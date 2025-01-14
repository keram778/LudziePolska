using LudziePolska.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LudziePolska
{
    public partial class ExportProvinceForm : Form
    {
        List<Province> provinces = new List<Province>();
        List<Person> people = new List<Person>();
        public ExportProvinceForm(List<Province> provinces, List<Person> people)
        {
            InitializeComponent();
            this.provinces = provinces;
            this.people = people;

            foreach (Province province in provinces)
            {
                provinceCombo.Items.Add(province.ProvinceName);
            }

            provinceCombo.SelectedIndex = 0;
        }

        private void exportBtn_Click(object sender, System.EventArgs e)
        {
            exportBtn.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            var peopleFiltered = people.Where(x => x.NazwaWojewodztwa == provinceCombo.Text).ToList();
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
            foreach (Person person in peopleFiltered)
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
            exportBtn.Enabled = true;
        }
    }
}
