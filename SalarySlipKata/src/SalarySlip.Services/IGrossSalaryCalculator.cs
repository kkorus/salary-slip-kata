namespace SalarySlip.Services
{
    public interface IGrossSalaryCalculator
    {
        decimal CalculateGrossSalary(decimal employeeAnnualGrossSalary);
    }
}