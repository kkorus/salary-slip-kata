using System;

namespace SalarySlip.Services
{
    public class SalarySlipGenerator
    {
        private readonly IGrossSalaryCalculator _grossSalaryCalculator;
        private readonly INationalInsuranceCalculator _nationalInsurance;
        private readonly ITaxCalculator _taxCalculator;

        public SalarySlipGenerator(
            IGrossSalaryCalculator grossSalaryCalculator,
            INationalInsuranceCalculator nationalInsurance,
            ITaxCalculator taxCalculator)
        {
            _grossSalaryCalculator = grossSalaryCalculator;
            _nationalInsurance = nationalInsurance;
            _taxCalculator = taxCalculator;
        }

        public SalarySlip GenerateFor(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            var grossSalary = _grossSalaryCalculator.CalculateGrossSalary(employee.AnnualGrossSalary);
            var nationalInsurance = _nationalInsurance.CalculateNationalInsurance(employee.AnnualGrossSalary);
            var tax = _taxCalculator.CalculateTax(employee.AnnualGrossSalary);

            var salarySlip = new SalarySlip(
                employee.Id,
                employee.Name,
                grossSalary,
                nationalInsurance,
                tax.TaxFree,
                tax.TaxableIncome,
                tax.TaxPayable);
            return salarySlip;
        }
    }
}