using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository subCategoryRepository;

        private readonly ICategoryService categoryService; 

        public SubCategoryService(ICategoryService categoryService, ISubCategoryRepository subCategoryRepository)
        {
            this.categoryService = categoryService;
            this.subCategoryRepository = subCategoryRepository; 
        }

        public SubCategory CreateSubCategory(int selectedCategoryId, string nameOfNewSubCategory)
        {
            var getCategory = categoryService.GetCategoryById(selectedCategoryId);

            if (getCategory == null)
            {
                MessageBox.Show("Category need to be selected!");
                return null;
            }

            if (string.IsNullOrEmpty(nameOfNewSubCategory))
            {
                MessageBox.Show("Please, entry with name of new Sub Categorie");
                return null;
            }

            var newSubCategory = new SubCategory()
            {
                Name = nameOfNewSubCategory,
                Category = getCategory 
            };

            subCategoryRepository.InsertSubCategory(newSubCategory);

            return newSubCategory;
        }

        public List<SubCategory> GetSubCategoriesByCategoryId(SubCategory subCategory, int categoryId) 
        {       
            return subCategoryRepository.GetAllSubCategories(subCategory).Where(subCategory => subCategory.Category.Id == categoryId).ToList();
        }
    }
}
