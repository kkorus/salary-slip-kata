﻿using System;

namespace SalarySlip.Services
{
    public class NationalInsuranceCalculator : INationalInsuranceCalculator
    {
        private const decimal NationalInsuranceTreshold = 8060M;

        private const decimal NationalInsuranceInterest = 0.12M;

        public decimal CalculateNationalInsurance(decimal employeeAnnualGrossSalary)
        {
            if (employeeAnnualGrossSalary > NationalInsuranceTreshold)
            {
                var taxtable = employeeAnnualGrossSalary - NationalInsuranceTreshold;
                var insurance = taxtable * NationalInsuranceInterest;
                return Math.Round(insurance / 12, 2);
            }

            return 0;
        }
    }
}