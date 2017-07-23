using FluentAssertions;
using NUnit.Framework;

namespace SalarySlip.Services.Tests
{
    public class GrossSalaryCalculatorShould
    {
        private GrossSalaryCalculator _grossSalaryCalculator;

        [SetUp]
        public void SetUp()
        {
            _grossSalaryCalculator = new GrossSalaryCalculator();
        }

        [Test]
        public void Return_GrossSalary_Per_Month()
        {
            // Arrange
            var annualGrossSalary = 5000M;

            // Act
            var grossSalary = _grossSalaryCalculator.CalculateGrossSalary(annualGrossSalary);

            // Assert
            grossSalary.Should().Be(416.67m);
        }
    }
}