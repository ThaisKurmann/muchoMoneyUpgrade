using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseContext _databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int InsertCategory(Category newCategory)
        {
            _databaseContext.Categories.Add(newCategory);
            _databaseContext.SaveChanges();

            return newCategory.Id;
        }

        public Category GetCategoryByName(string name)
        {
            return _databaseContext.Categories.FirstOrDefault(category => category.Name == name);
        }
    }
}
