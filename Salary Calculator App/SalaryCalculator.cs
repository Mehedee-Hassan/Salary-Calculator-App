using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator_App
{
    class SalaryCalculator
    {
        private double basicAccount;
        private double houseRentPercent;
        private double medicalAllowancePercent;

        public string Name { get; set; }




        public SalaryCalculator()
        {
            
        }

        public SalaryCalculator(string name , double basicAccount ,double houseRentPercent ,double medicalAllowancePercent )
        {
            this.Name = name;
            this.basicAccount = basicAccount;
            this.houseRentPercent = houseRentPercent;
            this.medicalAllowancePercent = medicalAllowancePercent;
        }


        public double CalculateSalary()
        {
            return basicAccount + (basicAccount * (GethouseRentPercentCalculated() + GetMedicalAllowanceCalculated()));
        }


        private double GethouseRentPercentCalculated()
        {
            return (houseRentPercent/100);
        }

        private double GetMedicalAllowanceCalculated()
        {
            return (medicalAllowancePercent/100);
        }

        public double HouseRentPercent
        {
            set { houseRentPercent = value; }
        }



        public double MedicalAllowancePercent
        {
           
            set { medicalAllowancePercent = value; }
        }

        public double BasicAccount
        {
           
            set { basicAccount = value; }
        }

    }
}
