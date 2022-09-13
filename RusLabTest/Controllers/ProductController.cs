using Microsoft.AspNetCore.Mvc;
using RusLabTest.Contracts;
using RusLabTest.Models;
using RusLabTest.Services.Interfaces;

namespace RusLabTest.Controllers
{
    [ApiController]
    [Route("purchase")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService purchaseService)
        {
            _productService = purchaseService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var purchase = await _productService.GetAsync(id);
            return Ok(purchase);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ProductCreateContract request)
        {
            var result = await _productService.InsertAsync(request);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _productService.DeleteAsync(id);
            return Ok();
        }

        [HttpPatch]
        public async Task<ActionResult> Patch([FromBody] ProductUpdateContract request)
        {
            var product = await _productService.UpdateAsync(request);
            return Ok(product);
        }
    }
}