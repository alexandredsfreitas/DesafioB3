using DesafioB3.Domain.Models;
using DesafioB3.Domain.Services;
using DomainValidationCore.Validation;
using Xunit;

namespace DesafioB3.Domain.Tests.Services
{
    public class InvestimentServiceTests
    {
        [Fact]
        public async Task Should_Calculate_Investment_When_Valid()
        {
            var investment = new Investment(100, 12, 0.05M, 0.1M);
            var service = new InvestimentService();

            var result = await service.CalculateInvestmentAsync(investment);

            Assert.True(result.ValidationResult.IsValid);
            Assert.Equal("Cálculo do CDB realizado com sucesso.", result.ValidationResult.Message);
        }

        [Fact]
        public async Task Should_Not_Calculate_Investment_When_Invalid()
        {
            var investment = new Investment(0, 12, 0.05M, 0.1M);
            var service = new InvestimentService();

            var result = await service.CalculateInvestmentAsync(investment);

            Assert.False(result.ValidationResult.IsValid);
            Assert.Equal("Por favor, informe um Valor Inicial maior que zero para calcular este investimento.",
                result.ValidationResult.Errors.ToList()[0].Message);
        }
    }
}
