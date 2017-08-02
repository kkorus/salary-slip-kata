namespace SalarySlip.Services
{
    public interface ITaxCalculator
    {
        Tax CalculateTax(decimal annualGrossSalary);
    }
}