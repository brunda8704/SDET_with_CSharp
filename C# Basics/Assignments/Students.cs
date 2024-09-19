using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Students
    {
        string? name,grade;
        int[] marks;

        public Students(string? name, string? grade, int[] marks)
        {
            Name = name;
            Grade = grade;
            Marks = marks;
        }

        public string? Name { get => name; set => name = value; }
        public string? Grade { get => grade; set => grade = value; }
        public int[] Marks { get => marks; set => marks = value; }

        public double CalculateAverage()
        {
            return Marks.Average();
        }

        public string GetMarksSummary()
        {
            int highestMarks = Marks.Max();
            int lowestMarks = Marks.Min();
            return $"{name} has {Marks.Length} marks\nHighest mark:{highestMarks} Lowest mark:{lowestMarks}\n";
        }
    }
}
