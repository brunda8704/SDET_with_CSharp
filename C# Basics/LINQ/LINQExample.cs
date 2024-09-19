using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQExample
    {
        public void Display() 
        {
            List<string> courses = new List<string>()
            {
                {"C Tutorial"},
                {"C++ Tutorial"},
                {"Java Tutorial"},
                {"DBMS"},
                {"Web Tech"},
            };

            //Query Syntax
            //var result= from item in courses
            //            where item.Equals("DBMS")
            //            select item;

            //Method Syntax
            //var result = courses.Where(c => c.Equals("DBMS"));
            //foreach (var r in result)
            //{
            //    Console.WriteLine(r);
            //}

            var result = courses.Where(c => c.Contains("Tutorial"));
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        public void StudentDisplay()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Anu", "CS"));
            students.Add(new Student(2, "Sanju", "IT"));
            students.Add(new Student(3, "Lohith", "ISE"));
            students.Add(new Student(4, "Surya", "EC"));

            Student student1 = (Student)students.FirstOrDefault(s => s.Id == 3);
            if (student1 != null)
            {
                Console.WriteLine(student1.Id + " " + student1.Name + " " + student1.Department);
            }
            else
            {
                Console.WriteLine("Student not found");
            }
            List<Student> student = (List<Student>)students.FindAll(s => s.Name == "Surya" || s.Name=="Sanju");
            foreach (var item in student)
            {
                Console.WriteLine(item.Id +" " +item.Name +" "+item.Department);

            }
        }
        public void FilteringOfType()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("Three");
            arrayList.Add("Four");

            var numbers=arrayList.OfType<int>();
            var strings=arrayList.OfType<string>();

            foreach (int item in numbers)
            {
                Console.WriteLine("Integer:"+item);
            }
            foreach (string item in strings)
            {
                Console.WriteLine("String:"+item);
            }
        }

        public void SortOrderBy()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Anu", "CS"));
            students.Add(new Student(2, "Sanju", "IT"));
            students.Add(new Student(3, "Lohith", "ISE"));
            students.Add(new Student(4, "Surya", "EC"));

            var result=students.OrderByDescending(x=>x.Name).ThenBy(x=>x.Department);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name +" "+item.Department);
            }
        }

        public void Grouping()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Anu", "CS"));
            students.Add(new Student(2, "Sanju", "IT"));
            students.Add(new Student(3, "Lohith", "ISE"));
            students.Add(new Student(4, "Surya", "EC"));

            var result = students.ToLookup(s => s.Department);
            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1.Name+""+item1.Department);

                }

            }
        }
    }
}
