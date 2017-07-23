namespace SalarySlip.Services
{
    public class SalarySlip
    {
        public SalarySlip(
            int id,
            string name,
            decimal grossSalary,
            decimal nationalInsurance)
        {
            Id = id;
            Name = name;
            GrossSalary = grossSalary;
            NationalInsurance = nationalInsurance;
        }

        public int Id { get; }

        public string Name { get; }

        public decimal GrossSalary { get; }

        public decimal NationalInsurance { get; set; }
    }
}