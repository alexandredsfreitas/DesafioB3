using DomainValidationCore.Validation;

namespace DesafioB3.Application.ViewModels
{
	public class InvestmentViewModel
	{
        public Guid Id { get; }

        public decimal InitialAmount { get; set; }

        public int Months { get; set; }

        public decimal TB { get; set; }

        public decimal CDI { get; set; }

        public decimal GrossResult { get; set; }

        public decimal NetResult { get; set; }

        public ValidationResult ValidationResult { get; set; } = new ValidationResult();
    }
}

