using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsExample
{
    internal class CourseRegistration
    {
        private List<string> registeredStudents = new List<string>();
        public void RegisterStudent(string studentName)
        {
            Thread.Sleep(2000);
            lock (registeredStudents)
            {
                registeredStudents.Add(studentName);
                Console.WriteLine($"{studentName} has registered for the course.");
            }
        }

        public int GetRegisteredStudentCount()
        {
            lock (registeredStudents)
            {
                return registeredStudents.Count;
            }
        }
    }
}
