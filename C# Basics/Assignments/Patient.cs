using Assignments.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignments.ExceptionMessages.MyException;

namespace Assignments
{
    internal class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age {  get; set; }
        public string? Diagnosis {  get; set; }

        public static List<Patient> patients = new List<Patient>();
       
        public void AddPatient(int Id,string? Name,int Age,string Diagnosis)
        {
            if(Age<0 || Age>=120)
            {
                throw new CustomException(ErrorMessages["Error1"]);
            }
            else if(string.IsNullOrEmpty(Name))
            {
                throw new CustomException(ErrorMessages["Error2"]);
            }
            else if(string.IsNullOrEmpty(Diagnosis))
            {
                throw new CustomException(ErrorMessages["Error3"]);
            }
            else
            {
                patients.Add(new Patient { Id = Id, Name = Name, Age = Age, Diagnosis = Diagnosis });
            }
        }

        
        public static void Display()
        {
            Console.WriteLine("Patient details");
            foreach (var item in patients)
            {
                Console.WriteLine("Id:"+item.Id +"\n" +"Name:"+item.Name+"\n" +"Age:"+item.Age+"\n"+"Diagnosis:"+item.Diagnosis);
            }
        }

        public void AddPatientToFile(int Id,string Name,int Age,string Diagnosis)
        {
           FileStream fileStream= new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Patient.txt", FileMode.Create, FileAccess.Write);
           StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Patient Id:"+Id);
            streamWriter.WriteLine("Patient Name:"+Name);
            streamWriter.WriteLine("Age:"+Age);
            streamWriter.WriteLine("Diagnosis:"+Diagnosis);
            streamWriter.Close();
            fileStream.Close();

        }
        public void ViewPatientDataFromFile()
        {
            FileStream fileStream1 = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Patient.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream1);
            string str=streamReader.ReadToEnd();
            Console.WriteLine(str);
            streamReader.Close();
        }
    }
    
}
