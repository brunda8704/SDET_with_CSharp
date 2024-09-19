using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Course : IEnrollable
    {
        public int CourseCode { get; set; }
        public string? Title { get; set; }

        public string? Instructor { get; set; }

        public int MaxCount { get; set; }

        public static List<Course> courses = new List<Course>();

        public List<Student> EnrolledStudent = new List<Student>();



        public void CourseRegistration(List<Student> Students)
        {
            foreach (var item in Course.courses)
            {
                Console.WriteLine("Course code:" + item.CourseCode + "\t" + "Title" + item.Title + "\t" + "Instructor:" + item.Instructor);
            }
            Console.WriteLine("Enter the Student Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var data = Students.Find(X => X.StudentId == id);
            if (data != null)
            {
                Console.WriteLine("Enter the course code do you want to enroll");
                int code = Convert.ToInt32(Console.ReadLine());
                var value = courses.Find(x => x.CourseCode == code);
                var item = EnrolledStudent.Find(x => x.StudentId == id);
                if (EnrolledStudent.Count >= value.MaxCount)
                {
                    throw new EnrollmentException(StudentException.ErrorMessages["1"]);

                }
                else if (item != null)
                {

                    Console.WriteLine($"Student {data.StudentId} already enrolled in course {code}");
                    throw new EnrollmentException(StudentException.ErrorMessages["2"]);
                }

                else
                {
                    EnrolledStudent.Add(data);
                    Console.WriteLine($"Student successfully registered!! ");
                    foreach (var student in EnrolledStudent)
                    {
                        Console.WriteLine("id:" + student.StudentId);
                    }

                }
            }
        }

        public void CourseWithdrawl(int id)
        {
            var found = courses.Find(x => x.CourseCode == id);
            var remove = found.EnrolledStudent.RemoveAll(x => x.StudentId == id);
            if (remove != null)
            {
                Console.WriteLine("Course withdrawed!");
            }
            else
            {
                Console.WriteLine("Course not withdrawed");
            }
        }
    }

}
