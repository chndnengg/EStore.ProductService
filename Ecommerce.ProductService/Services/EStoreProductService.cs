using AutoMapper;
using Ecommerce.ProductService.Adapters;
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
        private readonly FakeStoreServiceAdapter _adapter;
        private readonly IProductService _productService;
        public EStoreProductService(IProductRepository productRepository, IMapper mapper, ProductDBContext productDBContext)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            this._adapter = new FakeStoreServiceAdapter(mapper);
            this._productService = new ProductSQLAdapter(mapper, productDBContext);
        }
        public async Task<ProductDto> GetProductAsync(int id)
        {
            return await _productService.GetProductAsync(id);
        }
        public async Task<List<ProductDto>> GetProductAllAsync(Predicate<string> predicate)
        {
            return await _productService.GetProductAllAsync(predicate);
        }
        public async Task<ProductDto> CreateProductAsync(ProductDto productDto)
        {
            return await _adapter.CreateProductAsync(productDto);
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
