using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Repositories
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly DatabaseContext databaseContext;

        public SubCategoryRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public SubCategory InsertSubCategory(SubCategory newSubCategory)
        {
            var subCategoryName = GetSubCategoryByName(newSubCategory.Name);

            if (subCategoryName == null)
            {
                databaseContext.SubCategories.Add(newSubCategory);
                databaseContext.SaveChanges();

                return newSubCategory;
            }
            else
            {
                MessageBox.Show("SubCategory already exist!");
            }
                return null;
        }

        public List<SubCategory> GetAllSubCategories(SubCategory subCategory) 
        {
            return databaseContext.SubCategories.ToList();
        }

        public SubCategory GetSubCategoryByName(string subCategoryName)
        {
            return databaseContext.SubCategories.FirstOrDefault(subCategory => subCategory.Name == subCategoryName);
        }
    }
}
