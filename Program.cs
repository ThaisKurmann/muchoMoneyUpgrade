using System.Data.SQLite;

namespace MuchMoneyUpgrade
{
    internal static class Program
    {
        private const string DATABASE_FOLDER = "MuchMoney";
        [STAThread]
        static void Main()
        {
            string MuchMoneyPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DATABASE_FOLDER);
            bool checkPath = Directory.Exists(MuchMoneyPath);
            if (!checkPath)
            {
                Directory.CreateDirectory(MuchMoneyPath);
            }

            string dataBaseSqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{DATABASE_FOLDER}\\Database.sqlite");
            bool checkFile = File.Exists(dataBaseSqlitePath);

            var connectionString = $"Data Source={dataBaseSqlitePath}";
            var connection = new SQLiteConnection(connectionString);
            connection.Open();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}