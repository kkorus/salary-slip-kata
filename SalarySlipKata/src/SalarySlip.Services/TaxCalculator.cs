using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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

    public class Tax
    {
        public decimal TaxFree { get; set; }

        public decimal TaxableIncome { get; set; }

        public decimal TaxPayable { get; set; }

        public Tax(decimal taxFree, decimal taxableIncome, decimal taxPayable)
        {
            TaxFree = taxFree;
            TaxableIncome = taxableIncome;
            TaxPayable = taxPayable;
        }
    }

    public class NoTax : Tax
    {
        public NoTax() : base(0, 0, 0)
        {

        }
    }

    public interface ITaxCalculator
    {
        Tax CalculateTax(decimal annualGrossSalary);
    }

}
