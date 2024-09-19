using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StaffDetails:College
    {
        public int StaffId {  get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }

        public void DisplayStaffDetails()
        {
            Console.WriteLine($"Staff Id:" + StaffId + "\n" + "Staff Name:" + Name + "\n" + "Department:" + Department);
        }
    }
}
