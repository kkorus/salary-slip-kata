using System;

namespace SalarySlip.Services
{
    public class SalarySlipGenerator
    {
        public SalarySlip GenerateFor(Employee employee)
        {
            var grossSalary = CalculateGrossSalary(employee.AnnualGrossSalary);
            var salarySlip = new SalarySlip(employee.Id, employee.Name, grossSalary);
            return salarySlip;
        }

        private decimal CalculateGrossSalary(decimal employeeAnnualGrossSalary)
        {
            return Math.Round(employeeAnnualGrossSalary / 12, 2);
        }
    }
}