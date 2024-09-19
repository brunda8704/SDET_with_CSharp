using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class DelegateExample
    {
        public  int Num1, Num2;

        public void Add(int num1, int num2)
        {
            Num1=num1;
            Num2=num2;
            Console.WriteLine(Num1+Num2);
        }
        public int AddWithReturn(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
           return Num1+Num2;
        }
        public void Subtract(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
            Console.WriteLine(Num1 - Num2);
        }
        public static void MethodA(string message)
        {
            Console.WriteLine(message);
        }
    }
}
