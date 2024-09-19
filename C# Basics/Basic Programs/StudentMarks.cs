using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentMarks:StudentDetails
    {
        //public StudentMarks(int rollNo, string? studentName, string? city) 
        //    : base(rollNo, studentName, city)
        //{
        //    RollNo = rollNo;
        //    StudentName = studentName;
        //    City = city;
            
        //}

        public int Mark1 {  get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Total {  get; set; }
        public double Average {  get; set; }

        public int CalculateTotal()
        {
            Total=Mark1+ Mark2+ Mark3;
            return Total;
        }
        public double CalculateAverage()
        {
            Average = Total / 3;
            return Average;
        }
    }
}
