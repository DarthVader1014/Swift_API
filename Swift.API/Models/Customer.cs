using System.ComponentModel.DataAnnotations;

namespace Swift_API
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerFirstname { get; set; } = string.Empty;
        public string CustomerLastname { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;    

    }
}
