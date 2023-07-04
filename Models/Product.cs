using System.ComponentModel.DataAnnotations;

namespace SampleMVCApplication.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }

        public DateTime ModifiedTimeStamp { get; set; }

        //Relationship
        //public int CategoryId { get; set; }
    }
}
