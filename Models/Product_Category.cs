namespace SampleMVCApplication.Models
{
    public class Product_Category
    {
        public int ProductId { get; set; }
        Product Product { get; set; }


        public int CategoryId { get; set; }
        Category Category { get; set; }
    }
}
