using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MuchMoneyUpgrade.Repositories;
using MuchMoneyUpgrade.Services;

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

            var form = host.Services.GetRequiredService<MainForm>();
            
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                string dataBaseSqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{DATABASE_FOLDER}\\Database.sqlite");
                var connectionString = $"Data Source={dataBaseSqlitePath}";

                services.AddDbContext<DatabaseContext>(options =>
                    options.UseSqlite(connectionString));

                services.AddTransient<MainForm>();
                services.AddSingleton<CreateCategoryUiService>();
                services.AddSingleton<CategoryService>();
                services.AddSingleton<CategoryRepository>();
            });
    }
}