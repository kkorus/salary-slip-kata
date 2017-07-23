using System;
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
            var grossSalaryCalculator = new GrossSalaryCalculator();
            var nationalInsurance = new NationalInsuranceCalculator();
            _salarySlipGenerator = new SalarySlipGenerator(grossSalaryCalculator, nationalInsurance);
        }

        [Test]
        public void Throw_Exception_If_Employee_Is_Null()
        {
            // Arrange

            // Act
            Action act = () => _salarySlipGenerator.GenerateFor(null);

            // Assert
            act.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void Return_SalarySlip_With_GrossSalary()
        {
            // Arrange
            Employee employee = new Employee(12345, "John J Doe", 5000M);

            // Act
            SalarySlip salarySlip = _salarySlipGenerator.GenerateFor(employee);

            // Assert
            salarySlip.Id.Should().Be(12345);
            salarySlip.Name.Should().Be("John J Doe");
            salarySlip.GrossSalary.Should().Be(416.67M);
            salarySlip.NationalInsurance.Should().Be(0);
        }

        [Test]
        public void Return_SalarySlip_With_National_Insurance_Contribution()
        {
            // Arrange
            Employee employee = new Employee(12345, "John J Doe", 9060M);

            // Act
            SalarySlip salarySlip = _salarySlipGenerator.GenerateFor(employee);

            // Assert
            salarySlip.Id.Should().Be(12345);
            salarySlip.Name.Should().Be("John J Doe");
            salarySlip.GrossSalary.Should().Be(755M);
            salarySlip.NationalInsurance.Should().Be(10M);
        }
    }
}
