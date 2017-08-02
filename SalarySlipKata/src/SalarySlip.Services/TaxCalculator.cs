using System;

namespace SalarySlip.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        private const decimal TaxTreshold = 11000M;
        private const decimal TaxRate = 0.2M;

        public Tax CalculateTax(decimal annualGrossSalary)
        {
            if (annualGrossSalary > TaxTreshold)
            {
                var taxedSalary = annualGrossSalary - TaxTreshold;
                var taxToPayInYear = taxedSalary * TaxRate;
                var taxableIncome = Math.Round(taxedSalary / 12, 2);
                var taxPayable = Math.Round(taxToPayInYear / 12, 2);
                var taxFree = taxedSalary - taxableIncome;
                return new Tax(taxFree, taxableIncome, taxPayable);
            }

            return new NoTax();
        }
    }
}