using System.ComponentModel.DataAnnotations;

namespace RusLabTest.Contracts
{
    public class ProductUpdateContract
    {
        [Required]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
    }
}
