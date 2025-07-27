using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;
using MuchMoneyUpgrade.Repositories;

namespace MuchMoneyUpgrade.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void CreateCategory(string categoryName)
        {
            var categoryWithInputName = _categoryRepository.GetCategoryByName(categoryName);

            if (categoryWithInputName == null)
            {
                var newCategory = new Category()
                {
                    Name = categoryName
                };

                _categoryRepository.InsertCategory(newCategory);

                MessageBox.Show($"Category '{newCategory.Name}' created");
            }
            else
            {
                MessageBox.Show("Category alread exist!");
            }
        }
    }
}
