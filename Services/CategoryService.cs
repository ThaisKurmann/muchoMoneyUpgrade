using MuchMoneyUpgrade.Models;
using MuchMoneyUpgrade.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchMoneyUpgrade.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void CreateCategory(string categoryName)
        {   
            var newCategory = new Category { Name = categoryName };
            _categoryRepository.InsertCategory(newCategory);
        }
    }

}
