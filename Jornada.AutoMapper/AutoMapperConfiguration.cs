using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Jornada.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterMappings(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(

                mc =>
                {
                    mc.AddProfile(new EntityToDTOMaper());
                    mc.AddProfile(new DTOToEntityMapper());

                });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
