using System;

namespace SalarySlip.Services
{
    public class SalarySlipGenerator
    {
        private readonly IGrossSalaryCalculator _grossSalaryCalculator;
        private readonly INationalInsuranceCalculator _nationalInsurance;

        public SalarySlipGenerator(
            IGrossSalaryCalculator grossSalaryCalculator,
            INationalInsuranceCalculator nationalInsurance)
        {
            _grossSalaryCalculator = grossSalaryCalculator;
            _nationalInsurance = nationalInsurance;
        }

        public SalarySlip GenerateFor(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            var grossSalary = _grossSalaryCalculator.CalculateGrossSalary(employee.AnnualGrossSalary);
            var nationalInsurance = _nationalInsurance.CalculateNationalInsurance(employee.AnnualGrossSalary);

            var salarySlip = new SalarySlip(employee.Id, employee.Name, grossSalary, nationalInsurance);
            return salarySlip;
        }
    }
}