using AutoMapper;
using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Services;

namespace Ecommerce.ProductService.Mappings
{
    public class MappingProfiles : Profile
    {
        public  MappingProfiles() 
        { 
            CreateMap<EstoreProductDto, ProductDto>().ReverseMap();
        }
    }
}
