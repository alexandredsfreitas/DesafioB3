using DesafioB3.Application.ViewModels;

namespace DesafioB3.Application.Interfaces
{
	public interface IInvestmentAppService : IDisposable
	{
        Task<InvestmentViewModel> CalculateInvestmentAsync(InvestmentViewModel investment);
    }
}

