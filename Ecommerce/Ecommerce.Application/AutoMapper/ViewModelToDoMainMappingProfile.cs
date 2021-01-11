using AutoMapper;
using Ecommerce.Application.Dtos;
using Ecommerce.Data.Entities;

namespace Ecommerce.Application.AutoMapper
{
    public class ViewModelToDoMainMappingProfile : Profile
    {
        public ViewModelToDoMainMappingProfile()
        {
            CreateMap<ProductDtos, Product>();
        }
    }
}
