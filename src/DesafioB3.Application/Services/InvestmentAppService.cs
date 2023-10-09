using DesafioB3.Application.Interfaces;
using DesafioB3.Application.ViewModels;
using DesafioB3.Domain.Interfaces;
using AutoMapper;
using DesafioB3.Domain.Models;

namespace DesafioB3.Application.Services
{
	public class InvestmentAppService : IInvestmentAppService
	{
        private IMapper _mapper;

        private IInvestimentService _investimentService;

        public InvestmentAppService(IMapper mapper, IInvestimentService investimentService)
		{
            _mapper = mapper;
            _investimentService = investimentService;
        }

        public async Task<InvestmentViewModel> CalculateInvestmentAsync(InvestmentViewModel investmentViewModel)
        {
            var investment = _mapper.Map<Investment>(investmentViewModel);

            var result = _mapper.Map<InvestmentViewModel>(await _investimentService.CalculateInvestmentAsync(investment));

            return result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

