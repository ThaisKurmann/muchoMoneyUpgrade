using Microsoft.EntityFrameworkCore;
using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseContext databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public int InsertCategory(Category newCategory)
        {
            databaseContext.Categories.Add(newCategory);
            databaseContext.SaveChanges();

            return newCategory.Id;
        }

        public Category GetCategoryByName(string name)
        {
            return databaseContext.Categories.Where(category => category.Name == name)
                .Include(category => category.SubCategories)
                .FirstOrDefault();
        }

        public List<Category> GetAllCategories() 
        { 
            return databaseContext.Categories.ToList();
        }

    }
}
