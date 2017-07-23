namespace SalarySlip.Services
{
    public class SalarySlip
    {
        public SalarySlip(int id, string name, decimal grossSalary)
        {
            Id = id;
            Name = name;
            GrossSalary = grossSalary;
        }

        public int Id { get; }
        public string Name { get; }
        public decimal GrossSalary { get; }
    }
}