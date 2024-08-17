using AutoMapper;

namespace LIMS.Application.Mappers
{
    public static class AutoMapperConfiguration
    {
        private static IMapper CreateAutoMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
        }

        public static IMapper Mapper => CreateAutoMapper();
    }
}
