using DesafioB3.Domain.Models;
using DesafioB3.Domain.Specifications;
using Xunit;

namespace DesafioB3.Domain.Tests.Specifications
{
	public class InvestmentMonthsValueMustBeGreaterThanOneSpecificationTests
	{
        [Fact]
        public void Should_Be_Valid_When_Months_Is_Greater_Than_One()
        {
            var investment = new Investment(100, 2, 0.05M, 0.1M);
            var specification = new InvestmentMonthsValueMustBeGreaterThanOneSpecification();

            var result = specification.IsSatisfiedBy(investment);

            Assert.True(result);
        }

        [Fact]
        public void Should_Be_Invalid_When_Months_Is_One()
        {
            var investment = new Investment(100, 1, 0.05M, 0.1M);
            var specification = new InvestmentMonthsValueMustBeGreaterThanOneSpecification();

            var result = specification.IsSatisfiedBy(investment);

            Assert.False(result);
        }
    }
}

