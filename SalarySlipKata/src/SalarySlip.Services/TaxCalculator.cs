using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySlip.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public Tax CalculateTax(decimal annualGrossSalary)
        {
            throw new NotImplementedException();
        }
    }

    public class Tax
    {
        public decimal TaxFree { get; set; }

        public decimal TaxableIncome { get; set; }

        public decimal TaxPayable { get; set; }
    }

    public interface ITaxCalculator
    {
        Tax CalculateTax(decimal annualGrossSalary);
    }

}
