using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NonTeachingStaff:TeachingStaff
    {
        public string? Responsibilities { get; set; }
        public int Experience { get; set; }

        public void DisplayNonTeachingStaffDetails()
        {
            Console.WriteLine($"Responsibilities:" + Responsibilities + "\n" + "Experience :" + Experience);
        }
    }
}
