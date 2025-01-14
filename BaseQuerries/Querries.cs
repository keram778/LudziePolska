using LudziePolska.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LudziePolska.BaseQuerries
{
    internal class Querries
    {
        public static List<Person> GetPoeple()
        {
            List<Person> list = new List<Person>();
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //read data from database
            string querry = "SELECT ID_Osoby,Imie, Nazwisko, PESEL, DataUrodzenia, KolorSkory, Wojewodztwa.NazwaWojewodztwa, Zawod FROM Osoby INNER JOIN Wojewodztwa ON Osoby.ID_Wojewodztwa = Wojewodztwa.ID_Wojewodztwa";
            SqlCommand command = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            //copy data to list of person
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Person
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

            ExtensionMethods.LogTransaction(querry);

            return list;

        }
        public static List<Province> GetProvinces()
        {
            List<Province> list = new List<Province>();
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //read data from database
            string querry = "select * from wojewodztwa order by id_wojewodztwa";
            SqlCommand command = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            //copy data to list of provinces
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Province
                {
                    ID_Wojewodztwa = Convert.ToInt32(row["ID_Wojewodztwa"]),
                    ProvinceName = row["NazwaWojewodztwa"].ToString(),
                });
            }

            ExtensionMethods.LogTransaction(querry);

            return list;
        }
        public static List<string> GetSkinColors()
        {
            List<string> list = new List<string>();
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            //read unique records from database
            string querry = "select distinct kolorskory from osoby";
            SqlCommand command = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            //copy data to list of skincolors
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            ExtensionMethods.LogTransaction(querry);
            return list;
        }
        public static List<string> GetProffesions()
        {
            List<string> list = new List<string>();
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //read unique records from database
            string querry = "select distinct zawod from osoby";
            SqlCommand command = new SqlCommand(querry, con);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            //copy data to list of proffesions
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            ExtensionMethods.LogTransaction(querry);

            return list;
        }
        public static void DeleteSelected(DataGridViewSelectedRowCollection rows)
        {
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
            foreach (DataGridViewRow row in rows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                string querry = "delete from osoby where id_osoby=@id";
                SqlCommand command = new SqlCommand(querry, con);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                ExtensionMethods.LogTransaction(querry);
            }
        }
    }
}
