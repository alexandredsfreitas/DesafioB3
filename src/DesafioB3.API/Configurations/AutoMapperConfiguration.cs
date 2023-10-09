using DesafioB3.Application.AutoMapper;

namespace DesafioB3.API.Configurations
{
	public static class AutoMapperConfiguration
	{
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }
    }
}

