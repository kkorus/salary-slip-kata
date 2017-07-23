namespace SalarySlip.Services
{
    public interface INationalInsuranceCalculator
    {
        decimal CalculateNationalInsurance(decimal employeeAnnualGrossSalary);
    }
}