using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle : Shape, IDrawable
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; set; }
        public double Width { get; set; }

        public override void CalculateArea()
        {
            var area = Length * Width;
            Console.WriteLine("Area of Rectangle:" + area);
        }

        public override void CalculatePerimeter()
        {
            var perimeter = 2 * (Length + Width);
            Console.WriteLine("Perimeter of Rectangle:" + perimeter);
        }


        public void Draw()
        {
            Console.WriteLine("\nRectangle:");
        }
    }
}
