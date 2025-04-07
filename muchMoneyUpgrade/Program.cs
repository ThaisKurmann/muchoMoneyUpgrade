using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace muchMoneyUpgrade
{
    internal static class Program
    {
        private const string DATABASE_FOLDER = "MuchMoney";
        [STAThread]
        static void Main()
        {
            string MuchMoneyPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MuchMoney";
            bool checkPath = Directory.Exists(MuchMoneyPath);
            if (!checkPath)
            {
                Directory.CreateDirectory(MuchMoneyPath);
            }

            string DataBaseSqlitePath =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MuchMoney\\Database.sqlite";
            bool checkFile = File.Exists(DataBaseSqlitePath);
            if (!checkFile)
            {
                SQLiteConnection.CreateFile(DataBaseSqlitePath);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
