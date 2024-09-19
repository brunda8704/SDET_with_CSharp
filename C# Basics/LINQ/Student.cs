using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public Student(int id, string? name, string? department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }

    }
}
