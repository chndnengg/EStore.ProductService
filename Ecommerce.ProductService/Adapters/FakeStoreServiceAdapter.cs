using AutoMapper;
using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Repository;
using Ecommerce.ProductService.Services;

namespace Ecommerce.ProductService.Adapters
{
    public class FakeStoreServiceAdapter : BaseService, IProductService
    {
        private readonly IMapper _mapper;
        public FakeStoreServiceAdapter(IMapper mapper)
        {
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
        public async Task<ProductDto> CreateProductAsync(ProductDto productDto)
        {
            string url = "https://fakestoreapi.com/products/";
            EstoreProductDto estoreProductDto = _mapper.Map<EstoreProductDto>(productDto);
            var resonse = await CreateModel<EstoreProductDto>(url, estoreProductDto);
            ProductDto createProductDto = _mapper.Map<ProductDto>(resonse);
            return productDto;
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
