using AutoMapper;
using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Model;
using Ecommerce.ProductService.Services;
using Newtonsoft.Json;

namespace Ecommerce.ProductService.Repository
{
    public class ProductSQLAdapter : IProductService
    {
        private readonly IMapper _mapper;
        private readonly ProductDBContext _db;
        public ProductSQLAdapter(IMapper mapper, ProductDBContext productDBContext)
        {
            _mapper = mapper;
            this._db = productDBContext;
        }
        public async Task<ProductDto> GetProductAsync(int id)
        {
            Product product = _db.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return null;
            }
            var productJson = product.Details;
            EstoreProductDto estoreProductDto = JsonConvert.DeserializeObject<EstoreProductDto>(productJson);
            ProductDto productDto = _mapper.Map<ProductDto>(estoreProductDto);
            return productDto;
        }
        public async Task<List<ProductDto>> GetProductAllAsync(Predicate<string> predicate)
        {
            var productJsons = string.Join(", ", _db.Products.Select(x => x.Details));
            var productJsonArray = $"[{productJsons}]";
            List<EstoreProductDto> estoreProductsDtos = JsonConvert.DeserializeObject<List<EstoreProductDto>>(productJsonArray);
            List<ProductDto> productDtos = _mapper.Map<List<ProductDto>>(estoreProductsDtos);

            return productDtos;
        }
        public async Task<ProductDto> CreateProductAsync(ProductDto productDto)
        {
            return null;
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
