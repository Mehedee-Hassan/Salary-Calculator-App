using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator_App
{
    class SalaryCalculator
    {
        public string name;
        public double basicAccount;
        public double houseRent;
        public double medicalAllowance;

        public double CalculateSalary()
        {

            
                         return basicAccount+(basicAccount*((houseRent / 100) + (medicalAllowance / 100)));
        }
    }
}
