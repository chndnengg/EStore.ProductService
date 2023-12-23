using AutoMapper;
using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Model;
using Ecommerce.ProductService.Repository;
using Newtonsoft.Json;

namespace Ecommerce.ProductService.Services
{
    public class EStoreProductService : BaseService, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public EStoreProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ProductDto> GetProductAsync(int id)
        {
            string url = $"https://fakestoreapi.com/products/{id}";
            EstoreProductDto sourceProductDto = await GetModel<EstoreProductDto>(url);
            ProductDto productDto = _mapper.Map<ProductDto>(sourceProductDto);
            return productDto;
        }
        public async Task<List<ProductDto>> GetProductAllAsync(Predicate<string> predicate)
        {
            string url = "https://fakestoreapi.com/products/";
            List<EstoreProductDto> sourceProducts = await GetModel<List<EstoreProductDto>>(url);
            List<ProductDto> products = _mapper.Map<List<ProductDto>>(sourceProducts);

            return products;
        }
        public async Task<string> CreateProductAsync(string product)
        {
            throw new NotImplementedException();
        }
      
        public async Task<string> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<string> UpdateProductAsync(string product)
        {
            throw new NotImplementedException();
        }
    }
}
