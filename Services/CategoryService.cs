using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category CreateCategory(string categoryName)
        {
            var categoryWithInputName = _categoryRepository.GetCategoryByName(categoryName);

            if (categoryWithInputName != null)
            {
                MessageBox.Show("Category alread exist!");
                return null;
            }

            var newCategory = new Category()
            {
                Name = categoryName
            };

            _categoryRepository.InsertCategory(newCategory);

            MessageBox.Show($"Category '{newCategory.Name}' created");

            return newCategory;
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }
    }
}
