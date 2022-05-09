
using System.ComponentModel.DataAnnotations;


namespace Swift_API
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;    

    }
}
