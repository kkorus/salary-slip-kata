namespace SalarySlip.Services
{
    public class Employee
    {
        public Employee(
            int id,
            string name,
            decimal annualGrossSalary)
        {
            Id = id;
            Name = name;
            AnnualGrossSalary = annualGrossSalary;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal AnnualGrossSalary { get; set; }
    }
}