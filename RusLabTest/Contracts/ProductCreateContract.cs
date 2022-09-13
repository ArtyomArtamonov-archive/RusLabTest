using RusLabTest.Models;

namespace RusLabTest.Contracts
{
    public class ProductCreateContract
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }

        public Product GetProduct()
        {
            var product = new Product
            {
                ProductName = ProductName,
                ProductCode = ProductCode
            };

            return product;
        }
    }
}
