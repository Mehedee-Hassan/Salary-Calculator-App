using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SalaryCalculator aSalaryCalculator;

        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            aSalaryCalculator = new SalaryCalculator();

            aSalaryCalculator.name = employeeNameTextBox.Text;
            aSalaryCalculator.basicAccount = Convert.ToDouble(basicAccountTextBox.Text);
            aSalaryCalculator.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            aSalaryCalculator.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            //double salary = aSalaryCalculator.CalculateSalary();
            ShowSalary();


        }

        public void ShowSalary(){

            string message = aSalaryCalculator.name + ", your Salary is : " + aSalaryCalculator.CalculateSalary(); 
            MessageBox.Show(message);
        }
    }
}
