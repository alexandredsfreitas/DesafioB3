using DesafioB3.Domain.Models;

namespace DesafioB3.Domain.Interfaces
{
	public interface IInvestimentService : IDisposable
	{
        Task<Investment> CalculateInvestmentAsync(Investment investment);
    }
}

