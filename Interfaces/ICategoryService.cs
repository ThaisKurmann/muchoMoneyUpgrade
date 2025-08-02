using MuchMoneyUpgrade.Models;
using System.Reflection.Metadata.Ecma335;

namespace MuchMoneyUpgrade.Interfaces
{
    public interface ICategoryService
    {
        public Category CreateCategory(string categoryName);
        public List<Category> GetAllCategories();
        
    }
}
