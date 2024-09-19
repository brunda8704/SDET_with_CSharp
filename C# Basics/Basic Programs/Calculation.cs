using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Calculation
    {
        double firstNumber, secondNumber, sum;
        public double Add(int firstNumber, int secondNumber)
        {
            sum = firstNumber + secondNumber;
            return sum;

        }

    }
}