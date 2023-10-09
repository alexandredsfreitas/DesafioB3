using Microsoft.AspNetCore.Mvc;
using DesafioB3.Application.Interfaces;
using DesafioB3.Application.ViewModels;

namespace DesafioB3.API.Controllers
{
	public class InvestmentController : APIController
	{
		private readonly decimal _tb = 1.08M;
		private readonly decimal _cdi = 0.009M;

        private readonly IInvestmentAppService _investmentAppService;

		public InvestmentController(IInvestmentAppService investmentAppService)
		{
			_investmentAppService = investmentAppService;
        }

		[HttpPost("CalculateInvestment")]
		public async Task<IActionResult> Post([FromBody] InvestmentRequestViewModel investmentRequestViewModel)
		{
			var investmentViewModel = new InvestmentViewModel()
			{
				InitialAmount = investmentRequestViewModel.InitialAmount,
				Months = investmentRequestViewModel.Months,
				TB = _tb,
				CDI = _cdi
			};

			var result = await _investmentAppService.CalculateInvestmentAsync(investmentViewModel);

			if (!result.ValidationResult.IsValid)
				return CustomResponse(result.ValidationResult);

            return CustomResponse(result);
		}
	}
}

