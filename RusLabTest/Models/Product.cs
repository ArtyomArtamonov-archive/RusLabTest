using System.ComponentModel.DataAnnotations;

namespace RusLabTest.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public long CreationDate { get; set; } = DateTimeOffset.Now.ToUnixTimeSeconds();
    }
}
