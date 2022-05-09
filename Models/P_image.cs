using System.ComponentModel.DataAnnotations;

namespace Swift_API
{
    public class P_image
    {
        [Key]
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public string FrontDisplay { get; set; } = string.Empty;

    }
}
