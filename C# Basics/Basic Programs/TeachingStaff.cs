using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class TeachingStaff:StaffDetails
    {
        public string? Specialization {  get; set; }
        public int Semester {  get; set; }

        public void DisplayTeachingStaffDetails()
        {
            Console.WriteLine($"Specialization:" +Specialization + "\n" +"Semester:" +Semester);
        }
    }
}
