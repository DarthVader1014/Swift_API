using System.ComponentModel.DataAnnotations;

namespace Swift_API
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;

    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;


  }
}
