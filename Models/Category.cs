namespace OnlineShopping.Models
{
    public class Category
    {
        public int id { get; set; }
        public String name { get; set; }
        public virtual IList<Product>? Products { get; set; }
    }
}
