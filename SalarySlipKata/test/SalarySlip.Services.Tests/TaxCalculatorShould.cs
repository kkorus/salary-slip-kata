using FluentAssertions;
using NUnit.Framework;

namespace SalarySlip.Services.Tests
{
    [TestFixture]
    public class TaxCalculatorShould
    {
        private TaxCalculator _taxCalculator;

        [SetUp]
        public void SetUp()
        {
            _taxCalculator = new TaxCalculator();
        }

        [TestCase(100)]
        [TestCase(11000)]
        public void Return_0_When_Annual_Salary_Dont_Exceeds_Threshold(decimal annualGrossSalary)
        {
            // Arrange

            // Act
            Tax tax = _taxCalculator.CalculateTax(annualGrossSalary);

            // Assert
            tax.TaxFree.Should().Be(0);
            tax.TaxableIncome.Should().Be(0);
            tax.TaxPayable.Should().Be(0);
        }

        [Test]
        public void Return_Tax_When_Annual_Salary_Exceeds_Threshold()
        {
            // Arrange
            var annualGrossSalary = 12000M;

            // Act
            Tax tax = _taxCalculator.CalculateTax(annualGrossSalary);

            // Assert
            tax.TaxFree.Should().Be(916.67M);
            tax.TaxableIncome.Should().Be(83.33M);
            tax.TaxPayable.Should().Be(16.67M);
        }
    }
}
