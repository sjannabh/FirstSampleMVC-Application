using System.ComponentModel.DataAnnotations;

namespace SampleMVCApplication.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime ModifiedTimeStamp { get; set; }

        //relationships
        //public List<Product_Category> Product_Category { get; set; }
    }
}
