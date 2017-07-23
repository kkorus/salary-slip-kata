using FluentAssertions;
using NUnit.Framework;

namespace SalarySlip.Services.Tests
{
    [TestFixture]
    public class SalarySlipGeneratorShould
    {
        private SalarySlipGenerator _salarySlipGenerator;

        [SetUp]
        public void SetUp()
        {
            _salarySlipGenerator = new SalarySlipGenerator();
        }

        [Test]
        public void Return_SalarySlip_For_Employee()
        {
            // Arrange
            Employee employee = new Employee(12345, "John J Doe", 5000M);

            // Act
            SalarySlip salarySlip = _salarySlipGenerator.GenerateFor(employee);

            // Assert
            salarySlip.Id.Should().Be(12345);
            salarySlip.Name.Should().Be("John J Doe");
            salarySlip.GrossSalary.Should().Be(416.67M);
        }
    }
}
