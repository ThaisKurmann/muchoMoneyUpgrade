using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category CreateCategory(string categoryName)
        {
            var categoryWithInputName = categoryRepository.GetCategoryByName(categoryName);

            if (categoryWithInputName != null)
            {
                MessageBox.Show("Category alread exist!");
                return null;
            }

            var newCategory = new Category()
            {
                Name = categoryName                
            };

            categoryRepository.InsertCategory(newCategory);

            MessageBox.Show($"Category '{newCategory.Name}' created");

            return newCategory;
        }

        public List<Category> GetAllCategories()
        {
            return categoryRepository.GetAllCategories();
        }

        public Category GetCategoryByName(string name)
        {
            var categoryWithInputName = categoryRepository.GetCategoryByName(name);

            if (categoryWithInputName == null) {
                return null;
            }

            return categoryWithInputName;
        }
    }
}
