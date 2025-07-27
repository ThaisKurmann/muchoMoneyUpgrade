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

        public void CreateCategory(string categoryWithInputName)
        {
            var result = _categoryRepository.GetCategoryByName(categoryWithInputName);

            if (result == null)
            {
                var newCategory = new Category()
                {
                    Name = categoryWithInputName
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
