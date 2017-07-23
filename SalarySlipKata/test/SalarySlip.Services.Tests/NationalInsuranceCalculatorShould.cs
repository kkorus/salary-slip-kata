using FluentAssertions;
using NUnit.Framework;

namespace SalarySlip.Services.Tests
{
    [TestFixture]
    public class NationalInsuranceCalculatorShould
    {
        private NationalInsuranceCalculator _nationalInsurance;

        [SetUp]
        public void SetUp()
        {
            _nationalInsurance = new NationalInsuranceCalculator();
        }

        [TestCase(100)]
        [TestCase(8060)]
        public void Return_0_When_Annual_Salary_Dont_Exceeds_Threshold(decimal annualGrossSalary)
        {
            // Arrange

            // Act
            var nationalInsuranceTax = _nationalInsurance.CalculateNationalInsurance(annualGrossSalary);

            // Assert
            nationalInsuranceTax.Should().Be(0);
        }

        [Test]
        public void Return_Tax_When_Annual_Salary_Exceeds_Threshold()
        {
            // Arrange
            var annualGrossSalary = 9060;

            // Act
            var nationalInsuranceTax = _nationalInsurance.CalculateNationalInsurance(annualGrossSalary);

            // Assert
            nationalInsuranceTax.Should().Be(10);
        }
    }
}