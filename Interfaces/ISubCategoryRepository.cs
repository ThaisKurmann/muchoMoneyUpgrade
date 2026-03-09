using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Interfaces
{
    public interface ISubCategoryRepository
    {
        public SubCategory InsertSubCategory(SubCategory newSubCategory);

        public List<SubCategory> GetAllSubCategories(SubCategory subCategory);
    }
}
