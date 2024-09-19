using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Assignments
{
    internal class Employees
    {
        public Employees(int employeeId, string? employeeName, int performanceRating)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            PerformanceRating = performanceRating;
        }

        public int EmployeeId {  get; set; }
        public string? EmployeeName { get; set; }
        public int PerformanceRating { get; set; }
        public decimal bonus;

        public static List<Employees> employeesList=new List<Employees>();
        public void AddEmployee(Employees employee)
        {
            employeesList.Add(employee);
           
        }
        public decimal PerformanceBasedBonus(Employees employees)
        { 
            
            if(employees.PerformanceRating>=4)
            {
                return employees.PerformanceRating * 4000;
            }
            else if (employees.PerformanceRating >= 3)
            {
                return employees.PerformanceRating * 3000;
            }
            else
            {
                return employees.PerformanceRating*1000;
            }
        }
        public decimal DepartmentSpecificBonus(Employees employees)
        {
            if (employees.PerformanceRating >= 4)
            {
                return employees.PerformanceRating * 4000;
            }
            else if (employees.PerformanceRating >= 3)
            {
                return employees.PerformanceRating * 3000;
            }
            else
            {
                return employees.PerformanceRating * 1000;
            }
        }

        //public void CalculateAndDisplayBonus(List<Employees> employees,BonusCalculation bonusCalculation)
        //{
        //    Console.WriteLine("Bonus:");
        //    foreach (Employees item in employees)
        //    {
        //        decimal bonus = bonusCalculation(item);
        //        Console.WriteLine($"{item.EmployeeName},Bonus:{bonus}");
        //    }
        //}
    }
}
