using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionMessages
{
    internal class MyException
    {
        public static Dictionary<string, string> ErrorMessages { get; set; } = new Dictionary<string, string>()
        {
            {"Error1","Age must be between 0 and 120" },
            {"Error2","Name should not be null or empty" },
            {"Error3","Diagnosis should not be null or empty" },
            {"Error4","Patient name and diagnosis should not be null or empty" },
            {"Error5","Treatment cost must be a positive number" }
        };
    }
        internal class CustomException:Exception
        {
            public CustomException(string message):base(message) { }
        }
        internal class  InvalidPatientDataException:Exception
        { 
            public InvalidPatientDataException(string? message) : base(message)
            {
            }
        }
        
        internal class InvalidMedicalRecordException:Exception
        {
           public InvalidMedicalRecordException(string? message):base(message) 
           {
           }
        }
    
}
