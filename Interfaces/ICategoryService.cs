using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Interfaces
{
    public interface ICategoryService
    {
        public void CreateCategory(string categoryName);
        public List<Category> GetAllCategories();
    }
}
