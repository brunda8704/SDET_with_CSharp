using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Circle : Shape,IDrawable
    {
        public double Radius {  get; set; }
        public readonly double pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            var area = pi * Radius * Radius;
            Console.WriteLine("Area of Circle:"+area);
        }

        public override void CalculatePerimeter()
        {
            var perimeter = 2 * pi * Radius;
            Console.WriteLine("Perimeter of Circle:" + perimeter+"\n");
        }

        public void Draw()
        {
            Console.WriteLine("\nCircle:");
        }
    }
}
