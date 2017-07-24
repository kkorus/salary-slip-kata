namespace SalarySlip.Services
{
    public class SalarySlip
    {
        public SalarySlip(int id, string name, decimal grossSalary, decimal nationalInsurance, decimal taxFree,
            decimal taxableIncome, decimal taxPayable)
        {
            Id = id;
            Name = name;
            GrossSalary = grossSalary;
            NationalInsurance = nationalInsurance;
            TaxFree = taxFree;
            TaxableIncome = taxableIncome;
            TaxPayable = taxPayable;
        }

        public int Id { get; }

        public string Name { get; }

        public decimal GrossSalary { get; }

        public decimal NationalInsurance { get; set; }

        public decimal TaxFree { get; set; }

        public decimal TaxableIncome { get; set; }

        public decimal TaxPayable { get; set; }
    }
}