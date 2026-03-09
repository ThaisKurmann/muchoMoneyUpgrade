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

        public int InsertSubCategory(SubCategory newSubCategory)
        {
            databaseContext.SubCategories.Add(newSubCategory);
            databaseContext.SaveChanges();

            return newSubCategory.Category.Id;
        }

        public List<SubCategory> GetAllSubCategories(SubCategory subCategory) 
        {
            return databaseContext.SubCategories.ToList();
        }

        public bool SubCategoryAlreadyExist(string subCategory, int category)
        {
            //testar e ve se pega apenas as subCategory da Category desejada!
            return true;
        }
    }
}
