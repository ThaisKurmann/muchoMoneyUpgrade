namespace MuchMoneyUpgrade.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<SubCategory> SubCategories {  get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
