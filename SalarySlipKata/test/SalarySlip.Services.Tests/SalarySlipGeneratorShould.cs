using NUnit.Framework;

namespace SalarySlip.Services.Tests
{
    public class SalarySlipGeneratorShould
    {
        private readonly SalarySlipGenerator _salarySlipGenerator;

        [SetUp]
        public void SetUp()
        {
            _salarySlipGenerator = new SalarSlipGenerator();
        }

        [Test]
        public void Return_SalarySlip_For_Employee()
        {
            // Arrange
            Employee employee = new Employee();

            // Act
            SalarySlip salarySlip = _salarySlipGenerator.GenerateFor(employee);

            // Assert
            salarySlip.Id.Should().Be(12345);
            salarySlip.Name.Should().Be("John J Doe");
            salarySlip.GrossSalary.Should().Be(416.67M);
        }
    }
}
