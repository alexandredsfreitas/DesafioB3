using DesafioB3.Domain.Models;
using DesafioB3.Domain.Validations;
using Xunit;

namespace DesafioB3.Domain.Tests.Validations
{
	public class InvestmentIsReadyToBeCalculatedValidationTests
	{
        [Fact]
        public void Should_Pass_Validation_When_All_Conditions_Are_Met()
        {
            var investment = new Investment(100, 12, 0.05M, 0.1M);
            var validation = new InvestmentIsReadyToBeCalculatedValidation();

            var result = validation.Validate(investment);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void Should_Fail_Validation_When_InitialAmount_Is_Zero()
        {
            var investment = new Investment(0, 12, 0.05M, 0.1M);
            var validation = new InvestmentIsReadyToBeCalculatedValidation();

            var result = validation.Validate(investment);

            Assert.False(result.IsValid);
            Assert.Equal("Por favor, informe um Valor Inicial maior que zero para calcular este investimento.",
                result.Errors.ToList()[0].Message);
        }

        [Fact]
        public void Should_Fail_Validation_When_Months_Is_One()
        {
            var investment = new Investment(100, 1, 0.05M, 0.1M);
            var validation = new InvestmentIsReadyToBeCalculatedValidation();

            var result = validation.Validate(investment);

            Assert.False(result.IsValid);
            Assert.Equal("Por favor, informe uma quantidade de meses maior que 1 para calcular este investimento.",
                result.Errors.ToList()[0].Message);
        }
    }
}

