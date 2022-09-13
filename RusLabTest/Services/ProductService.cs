using Microsoft.EntityFrameworkCore;
using RusLabTest.Contracts;
using RusLabTest.Data;
using RusLabTest.Models;
using RusLabTest.Services.Interfaces;
using System.Net;

namespace RusLabTest.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<Product> GetAsync(int id)
        {
            var purchase = await _context
                .Products
                .FirstOrDefaultAsync(x => x.Id == id);
            if (purchase is null)
            {
                throw new HttpRequestException("not found", null, HttpStatusCode.NotFound);
            }

            return purchase;
        }

        public async Task<Product> InsertAsync(ProductCreateContract contract)
        {
            var product = contract.GetProduct();
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> UpdateAsync(ProductUpdateContract contract)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == contract.Id);
            if (product is null)
            {
                throw new HttpRequestException("not found", null, HttpStatusCode.NotFound);
            }
            product.ProductName = contract.ProductName;
            product.ProductCode = contract.ProductCode;

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task DeleteAsync(int productId)
        {
            _context.Products.Remove(new Product { Id = productId });
            await _context.SaveChangesAsync();
        }
    }
}
