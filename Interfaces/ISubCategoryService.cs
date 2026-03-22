using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Interfaces
{
    public interface ISubCategoryService
    {
        public SubCategory CreateSubCategory(int selectedCategoryId, string nameOfNewSubCategory);
        public List<SubCategory> GetSubCategoriesByCategoryId(SubCategory subCategory, int categoryId);
    }
}
