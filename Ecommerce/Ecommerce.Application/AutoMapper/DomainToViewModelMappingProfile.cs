using AutoMapper;
using Ecommerce.Application.Dtos;
using Ecommerce.Data.Entities;

namespace Ecommerce.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductDtos>();
            CreateMap<ProductCategory, ProductCategoryDtos>();
        }
    }
}
