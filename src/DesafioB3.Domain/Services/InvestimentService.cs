using DesafioB3.Domain.Interfaces;
using DesafioB3.Domain.Models;

namespace DesafioB3.Domain.Services
{
	public class InvestimentService : IInvestimentService
    {
        public InvestimentService() { }

        public async Task<Investment> CalculateInvestmentAsync(Investment investment)
        {
            if (!investment.IsValid())
                return investment;

            await Task.Run(() => investment.CalculateInvestment());

            investment.ValidationResult.Message = "Cálculo do CDB realizado com sucesso.";

            return investment;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

