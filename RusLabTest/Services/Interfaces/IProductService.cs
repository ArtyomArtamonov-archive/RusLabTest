using RusLabTest.Contracts;
using RusLabTest.Models;

namespace RusLabTest.Services.Interfaces
{
    public interface IProductService
    {
        Task<Product> GetAsync(int id);
        Task<Product> InsertAsync(ProductCreateContract contract);
        Task<Product> UpdateAsync(ProductUpdateContract product);
        Task DeleteAsync(int productId);
    }
}
