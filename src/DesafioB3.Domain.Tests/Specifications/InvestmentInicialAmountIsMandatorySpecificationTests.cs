using DesafioB3.Domain.Models;
using DesafioB3.Domain.Specifications;
using Xunit;

namespace DesafioB3.Domain.Tests.Specifications
{
	public class InvestmentInicialAmountIsMandatorySpecificationTests
	{
        [Fact]
        public void Should_Be_Valid_When_InitialAmount_Is_Greater_Than_Zero()
        {
            var investment = new Investment(100, 12, 0.05M, 0.1M);
            var specification = new InvestmentInicialAmountIsMandatorySpecification();

            var result = specification.IsSatisfiedBy(investment);

            Assert.True(result);
        }

        [Fact]
        public void Should_Be_Invalid_When_InitialAmount_Is_Zero()
        {
            var investment = new Investment(0, 12, 0.05M, 0.1M);
            var specification = new InvestmentInicialAmountIsMandatorySpecification();

            var result = specification.IsSatisfiedBy(investment);

            Assert.False(result);
        }
    }
}

