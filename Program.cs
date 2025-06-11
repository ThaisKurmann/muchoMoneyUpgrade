using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data.Entity;
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
            
            var host = CreateHostBuilder().Build();
                    
            ApplicationConfiguration.Initialize();
           
            var databaseContext = host.Services.GetRequiredService<DatabaseContext>();
            databaseContext.Database.Migrate();
            
            var form = host.Services.GetRequiredService<Form1>();
            
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // Connection string
                string dataBaseSqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{DATABASE_FOLDER}\\Database.sqlite");
                var connectionString = $"Data Source={dataBaseSqlitePath}";

                // Registrar DbContext
                services.AddDbContext<DatabaseContext>(options =>
                    options.UseSqlite(connectionString));

                // Registrar formulários com dependências
                services.AddTransient<Form1>();
            });
    }
}