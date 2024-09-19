using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayable
    {
        private int EmployeeId {  get; set; }
        public Employee(string? firstName, string? lastName, int age, int employeeId)
            : base(firstName, lastName, age)
        {
            EmployeeId = employeeId;
        }

        public void DisplayInfo(int age)
        {
            //if (age >= 18 && age <= 100)
                Console.WriteLine($"Full name:"+FirstName + LastName +"\n" +"Age:"+Age+"\n"+"Employee Id:"+EmployeeId +"\n");
        }
    }
}
