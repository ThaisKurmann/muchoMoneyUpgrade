using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Interfaces
{
    public interface ICategoryRepository
    {
        public int InsertCategory(Category newCategory);
        public Category GetCategory(string name);

    }
}
