using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace LudziePolska.Classes
{
    static internal class ExtensionMethods
    {
        public static void EnableDoubleBuffered(DataGridView dgv)
        {
            //metoda poprawiająca wydajność kontrolki datagridview
            var dgvType = dgv.GetType();
            var pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, true, null);
        }
        public static void LogTransaction(string querry)
        {
            //zapis daty i czasu transakcji, tekstu transakcji oraz nazwy użytkownika Windows do pliku .txt
            using (StreamWriter sw = new StreamWriter("log.txt", append: true))
            {
                sw.WriteLine($"*** {DateTime.Now} {querry} , by: {Environment.UserName}");
            }
        }
    }
}
