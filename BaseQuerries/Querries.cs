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
            DataTable dt = new DataTable();
            string querry = "SELECT ID_Osoby,Imie, Nazwisko, PESEL, DataUrodzenia, KolorSkory, Wojewodztwa.NazwaWojewodztwa, Zawod FROM Osoby INNER JOIN Wojewodztwa ON Osoby.ID_Wojewodztwa = Wojewodztwa.ID_Wojewodztwa";
            using (SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return list;
                }
                //odczyt danych z bazy
                SqlCommand command = new SqlCommand(querry, con);
                dt.Load(command.ExecuteReader());
            }

            //skopiuj dane do listy Person
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
            DataTable dt = new DataTable();
            string querry = "select * from wojewodztwa order by id_wojewodztwa";
            using (SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return list;
                }

                //odczyt danych z bazy
                SqlCommand command = new SqlCommand(querry, con);
                dt.Load(command.ExecuteReader());
            }

            //kopiuj dane do lity województw
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
            DataTable dt = new DataTable();
            string querry = "select distinct kolorskory from osoby";
            using (SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return list;
                }
                //odczytaj unikatowe wartości z bazy dot. koloru skóry
                SqlCommand command = new SqlCommand(querry, con);
                dt.Load(command.ExecuteReader());
            }

            //kopiuj dane do listy kolorów skóry
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
            DataTable dt = new DataTable();
            string querry = "select distinct zawod from osoby";
            using (SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return list;
                }

                //odczytaj unikatowe wartości zawodów z bazy danych
                SqlCommand command = new SqlCommand(querry, con);
                dt.Load(command.ExecuteReader());
            }
            //kopiuj dane do listy zawodów
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            ExtensionMethods.LogTransaction(querry);

            return list;
        }
        public static void DeleteSelected(DataGridViewSelectedRowCollection rows)
        {
            string querry = "delete from osoby where id_osoby=@id";
            using (SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString()))
            {
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
                    //ustaw id wpisu do usunięcia - pierwsza komórka w tabeli
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    SqlCommand command = new SqlCommand(querry, con);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    ExtensionMethods.LogTransaction(querry);
                }
            }
        }
        public static void InsertPerson(Person person)
        {
            string querry = "insert into osoby (imie, nazwisko, pesel, dataurodzenia, kolorskory, id_wojewodztwa, zawod) values ";
            querry += "(@imie, @nazwisko, @pesel, @dataurodzenia, @kolorskory, @id_wojewodztwa, @zawod)";
            using (SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Brak połączenia z bazą danych. Sprawdź parametry połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlCommand command = new SqlCommand(querry, con);
                command.Parameters.AddWithValue("@imie", person.Imie);
                command.Parameters.AddWithValue("@nazwisko", person.Nazwisko);
                command.Parameters.AddWithValue("@pesel", person.Pesel);
                command.Parameters.AddWithValue("@dataurodzenia", person.DataUrodzenia);
                command.Parameters.AddWithValue("@kolorskory", person.KolorSkory);
                command.Parameters.AddWithValue("@id_wojewodztwa", person.ID_Wojewodztwo);
                command.Parameters.AddWithValue("@zawod", person.Zawod);
                command.ExecuteNonQuery();
            }
            ExtensionMethods.LogTransaction(querry);
        }
    }
}
