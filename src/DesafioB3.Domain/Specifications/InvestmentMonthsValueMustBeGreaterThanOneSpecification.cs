using DesafioB3.Domain.Models;
using DomainValidationCore.Interfaces.Specification;

namespace DesafioB3.Domain.Specifications
{
	public class InvestmentMonthsValueMustBeGreaterThanOneSpecification : ISpecification<Investment>
    {
        public bool IsSatisfiedBy(Investment entity)
        {
            if (entity.Months > 1)
                return true;

            return false;
        }
    }
}

