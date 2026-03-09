using MuchMoneyUpgrade.Models;
using MuchMoneyUpgrade.Repositories;
using MuchMoneyUpgrade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchMoneyUpgrade.Interfaces
{
    public interface ISubCategoryService
    {
        public SubCategory CreateSubCategory(string nameOfSelectedCategory, string nameOfNewSubCategory);
        public List<SubCategory> GetAllSubCategories(SubCategory subCategory, string categoryName);
    }
}
