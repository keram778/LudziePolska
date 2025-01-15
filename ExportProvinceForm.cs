using LudziePolska.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LudziePolska
{
    public partial class ExportProvinceForm : Form
    {
        List<Person> people = new List<Person>();
        public ExportProvinceForm(List<Province> provinces, List<Person> people)
        {
            InitializeComponent();
            this.people = people;

            //dodaj nazwy województw do comboboxa
            foreach (Province province in provinces)
                provinceCombo.Items.Add(province.ProvinceName);

            provinceCombo.SelectedIndex = 0;
        }
        private void exportBtn_Click(object sender, System.EventArgs e)
        {
            exportBtn.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            //użycie linq w celu wyszukania obiektów, które mają taką samą nazwę województwa co wybrana nazwa w combobox
            var peopleFiltered = people.Where(x => x.NazwaWojewodztwa == provinceCombo.Text).ToList();
            ExportToExcel.ExportToFile(peopleFiltered);
            Cursor.Current = Cursors.Arrow;
            exportBtn.Enabled = true;
        }
    }
}
