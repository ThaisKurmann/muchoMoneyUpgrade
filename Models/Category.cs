namespace MuchMoneyUpgrade.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SubCategory> SubCategory = new List<SubCategory>();

        public override string ToString()
        {
            return Name;
        }
    }
}
