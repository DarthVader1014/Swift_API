using System.ComponentModel.DataAnnotations;

namespace Swift_API
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductPrice { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string ProductDesc { get; set; } = string.Empty;
    }
}
