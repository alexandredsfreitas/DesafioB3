using DesafioB3.Domain.Models;
using DomainValidationCore.Interfaces.Specification;

namespace DesafioB3.Domain.Specifications
{
	public class InvestmentInicialAmountIsMandatorySpecification : ISpecification<Investment>
    {
        public bool IsSatisfiedBy(Investment entity)
        {
            if (entity.InitialAmount > 0)
                return true;

            return false;
        }
    }
}

