using Microsoft.Extensions.DependencyInjection;
using DesafioB3.Application.Interfaces;
using DesafioB3.Application.Services;
using DesafioB3.Domain.Interfaces;
using DesafioB3.Domain.Services;

namespace DesafioB3.Infra.CrossCutting.IOC
{
	public static class NativeInjectorBootStrapper
	{
		public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<IInvestmentAppService, InvestmentAppService>();

            // Domain
            services.AddScoped<IInvestimentService, InvestimentService>();
        }
	}
}

