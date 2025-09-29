using Microsoft.EntityFrameworkCore;
using MuchMoneyUpgrade.Models;
using System.Data.Common;

namespace MuchMoneyUpgrade
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
         : base(options)
        {
        }

        public DatabaseContext()
        {
        }
    }
}
