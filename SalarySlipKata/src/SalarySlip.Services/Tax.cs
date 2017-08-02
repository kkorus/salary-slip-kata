namespace SalarySlip.Services
{
    public class Tax
    {
        public Tax(decimal taxFree, decimal taxableIncome, decimal taxPayable)
        {
            TaxFree = taxFree;
            TaxableIncome = taxableIncome;
            TaxPayable = taxPayable;
        }

        public decimal TaxFree { get; set; }

        public decimal TaxableIncome { get; set; }

        public decimal TaxPayable { get; set; }
    }
}