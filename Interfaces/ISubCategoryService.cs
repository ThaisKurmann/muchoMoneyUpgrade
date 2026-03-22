using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Interfaces
{
    public interface ISubCategoryService
    {
        public SubCategory CreateSubCategory(int selectedCategoryId, string nameOfNewSubCategory);
        public List<SubCategory> GetAllSubCategories(SubCategory subCategory, int categoryId);
    }
}
