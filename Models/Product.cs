using Microsoft.Build.Framework;

namespace practiespp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; } 

        public double Price { get; set; }

        public string Imageurl { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public object Products { get; internal set; }
    }
}
