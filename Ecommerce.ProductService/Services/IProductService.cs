using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Model;

namespace Ecommerce.ProductService.Services
{
    public interface IProductService
    {
        Task<ProductDto> GetProductAsync(int id);
        Task<List<ProductDto>> GetProductAllAsync(Predicate<string> predicate);
        Task<string> CreateProductAsync(string product);
        Task<string> UpdateProductAsync(string product);
        Task<string> DeleteProductAsync(int id);
    }
}
