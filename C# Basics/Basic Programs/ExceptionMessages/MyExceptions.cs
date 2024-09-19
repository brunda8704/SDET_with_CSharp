using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class MyExceptions
    {
        //public static List<string> exceptionList = new List<string>()
        //{
        //    "Denominator cannot be zero",
        //    "Index is out of Range",
        //    "Unknown Exception"
        //};

        public static Dictionary<int, string> exceptionList = new Dictionary<int, string>()
        {
            {0,"Denominator cannot be zero" },
            {1,"Index is out of Range" },
            {2,"Unknown Exception"},
            {3,"First number is not greater than or equal to 100"},
            {4,"Second number must be lesser than 100" }
        };

        internal class NumberOneException : Exception
        {
            public NumberOneException(string message) : base(message)
            {
            }
        }

        internal class NumberTwoException : Exception
        {
            public NumberTwoException(string message) : base(message)
            {
            }
        }
    }
}
