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
            var result = _categoryRepository.GetCategory(categoryName);

            if (result == null)
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
