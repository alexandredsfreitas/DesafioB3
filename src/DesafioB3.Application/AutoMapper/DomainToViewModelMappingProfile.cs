using AutoMapper;
using DesafioB3.Application.ViewModels;
using DesafioB3.Domain.Models;

namespace DesafioB3.Application.AutoMapper
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public DomainToViewModelMappingProfile()
		{
            CreateMap<Investment, InvestmentViewModel>();
        }
	}
}

