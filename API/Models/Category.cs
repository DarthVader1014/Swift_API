using System.ComponentModel.DataAnnotations;

namespace Swift_API
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public string CategoryTitle { get; set; } =string.Empty;
        public string CategoryDesc { get; set; } = string.Empty;
    }
}
