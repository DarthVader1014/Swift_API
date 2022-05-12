using System.ComponentModel.DataAnnotations;

namespace Swift_API
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; } =string.Empty;
    }
}
