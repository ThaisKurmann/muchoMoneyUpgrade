//SALVAR NOVA CATEGORIA NO BD
//Ps: Se tiver duvidas como faz, basta olhar no programa do Bolao e tentar entender. Replique o codigo, caso tenha entendido;

using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade.Repositories
{
    public class CategoryRepository
    {
        private readonly DatabaseContext _databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int InsertCategory(Category newCategory)
        {
            _databaseContext.Categories.Add(newCategory);
            _databaseContext.SaveChanges();

            return newCategory.Id;
        }

    }
}
