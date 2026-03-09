using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;
using MuchMoneyUpgrade.Repositories;

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

        public SubCategory CreateSubCategory(string nameOfSelectedCategory, string nameOfNewSubCategory)
        {
            var getCategory = categoryService.GetCategoryByName(nameOfSelectedCategory);

            if(getCategory == null)
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

        public List<SubCategory> GetAllSubCategories(SubCategory subCategory, string categoryName) 
        {       
            return subCategoryRepository.GetAllSubCategories(subCategory).Where(subCategory => subCategory.Category.Name == categoryName).ToList();
        }
    }
}
