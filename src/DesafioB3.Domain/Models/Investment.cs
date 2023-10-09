using System;
using DesafioB3.Domain.Validations;
using DomainValidationCore.Validation;

namespace DesafioB3.Domain.Models
{
	public class Investment
	{
		public Guid Id { get; }

		public decimal InitialAmount { get; set; }

        public int Months { get; set; }

        public decimal TB { get; set; }

        public decimal CDI { get; set; }

        public decimal GrossResult { get; set; }

        public decimal NetResult { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public Investment(decimal initialAmount, int months, decimal tb, decimal cdi)
		{
			Id = Guid.NewGuid();
            InitialAmount = initialAmount;
            Months = months;
            TB = tb;
            CDI = cdi;

			ValidationResult = new ValidationResult();
		}

		public bool IsValid()
		{
            ValidationResult = new InvestmentIsReadyToBeCalculatedValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public void CalculateInvestment()
		{
            decimal VF = InitialAmount;

            for (int month = 0; month < Months; month++)
            {
                VF *= (1 + (CDI * TB));
            }

            decimal taxRate;

            if (Months <= 6)
            {
                taxRate = 0.225M; // 22,5%
            }
            else if (Months <= 12)
            {
                taxRate = 0.20M; // 20%
            }
            else if (Months <= 24)
            {
                taxRate = 0.175M; // 17,5%
            }
            else
            {
                taxRate = 0.15M; // 15%
            }

            GrossResult = VF - InitialAmount;

            decimal tax = GrossResult * taxRate;
            NetResult = GrossResult - tax;
        }
	}
}

