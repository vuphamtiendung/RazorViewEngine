namespace RazorViewEngine.Models
{
    public class ProductModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public bool Available { get; set; } 
        public double Price { get; set; }   
        public double PromotionPrice { get; set; }
    }
}
