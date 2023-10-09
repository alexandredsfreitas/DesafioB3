using DesafioB3.Infra.CrossCutting.IOC;

namespace DesafioB3.API.Configurations
{
	public static class DependencyInjectionConfiguration
	{
		public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
		{
			if (services == null)
				throw new ArgumentNullException(nameof(services));

			NativeInjectorBootStrapper.RegisterServices(services);
		}
	}
}

