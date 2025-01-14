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
            var dgvType = dgv.GetType();
            var pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, true, null);
        }

        public static void LogTransaction(string querry)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", append: true))
            {
                sw.WriteLine($"*** {DateTime.Now.ToShortTimeString()} {querry} , by: {Environment.UserName}");
            }
        }
    }
}
