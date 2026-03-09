using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Interfaces
{
    public interface ISubCategoryRepository
    {
        public int InsertSubCategory(SubCategory newSubCategory);

        public List<SubCategory> GetAllSubCategories(SubCategory subCategory);
    }
}
