using System;

namespace SalarySlip.Services
{
    public class GrossSalaryCalculator : IGrossSalaryCalculator
    {
        public decimal CalculateGrossSalary(decimal employeeAnnualGrossSalary)
        {
            return Math.Round(employeeAnnualGrossSalary / 12, 2);
        }
    }
}