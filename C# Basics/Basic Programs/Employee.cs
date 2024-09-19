using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Employee
    {
        private int empId;
        private string? empName,department;
        private double basicPay;
        private readonly int _bonus=10;
        public Employee(int empId, string? empName, string? department, double basicPay)
        {
            EmpId = empId;
            EmpName = empName;
            Department = department;
            BasicPay = basicPay;
        }

        public int EmpId { get => empId; set => empId = value; }
        public string? EmpName { get => empName; set => empName = value; }
        public string? Department { get => department; set => department = value; }
        public double BasicPay { get => basicPay; set => basicPay = value; }

        public int Bonus => _bonus;

        public double CalculateSalary()
        {
            double grossSalary, netSalary;
            double allowances = BasicPay * 0.3 + BasicPay * 0.2 + BasicPay * 0.15; //HRA+DA+CAA
            grossSalary = BasicPay + allowances;
            double deductions = BasicPay * 0.1; //EPF=10%
            netSalary = grossSalary-deductions;
            return netSalary;
        }
    }
}
