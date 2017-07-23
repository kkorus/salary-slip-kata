using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySlip.Services
{
    public class SalarySlip
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal GrossSalary { get; set; }
    }
}
