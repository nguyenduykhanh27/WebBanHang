using AutoMapper;

namespace Ecommerce.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ctg =>
            {
                ctg.AddProfile(new DomainToViewModelMappingProfile());
                ctg.AddProfile(new ViewModelToDoMainMappingProfile());
            });
        }
    }
}
