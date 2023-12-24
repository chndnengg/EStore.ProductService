using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Model;
using Ecommerce.ProductService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ProductService.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            ProductDto productDto = await _productService.GetProductAsync(id);
            if(productDto == null)
            {
                return NotFound($"Product with Id: {id} not found");
            }
            return Ok(productDto);
        }
        [HttpGet]
        public async Task<List<ProductDto>> GetProducts()
        {
            return await _productService.GetProductAllAsync(null);
        }
        [HttpPost]
        public async Task<ProductDto> CreateProduct([FromBody] ProductDto productDto)
        {
            return await _productService.CreateProductAsync(productDto);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] string product)
        {
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            return Ok($"Product {id} is deleted");
        }
    }
}
