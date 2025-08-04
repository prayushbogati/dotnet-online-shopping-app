namespace OnlineShopping.Models
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; } 
        public String? productImage { get; set; }
        public int categoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
