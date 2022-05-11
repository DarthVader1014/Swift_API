using System.ComponentModel.DataAnnotations;

namespace Swift_API
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }   

    }
}
