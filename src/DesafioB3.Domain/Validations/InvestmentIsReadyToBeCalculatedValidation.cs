using DesafioB3.Domain.Models;
using DesafioB3.Domain.Specifications;
using DomainValidationCore.Validation;

namespace DesafioB3.Domain.Validations
{
	public class InvestmentIsReadyToBeCalculatedValidation : Validator<Investment>
    {
		public InvestmentIsReadyToBeCalculatedValidation()
		{
            var investmentInicialAmountIsMandatorySpecification = new InvestmentInicialAmountIsMandatorySpecification();
            var investmentMonthsValueMustBeGreaterThanOneSpecification = new InvestmentMonthsValueMustBeGreaterThanOneSpecification();

            base.Add("investmentInicialAmountIsMandatorySpecification",
                new Rule<Investment>(investmentInicialAmountIsMandatorySpecification, "Por favor, informe um Valor Inicial maior que zero para calcular este investimento."));

            base.Add("investmentMonthsValueMustBeGreaterThanOneSpecification",
                new Rule<Investment>(investmentMonthsValueMustBeGreaterThanOneSpecification, "Por favor, informe uma quantidade de meses maior que 1 para calcular este investimento."));
        }
    }
}

