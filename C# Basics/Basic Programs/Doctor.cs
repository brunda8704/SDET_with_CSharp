using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Doctor : IDoctor,IAppointment
    {
        public int DoctorId { get; set; }   
        public string? DoctorName { get; set; }
        public void AddNewDoctor()
        {
            DoctorId = 1000;
            DoctorName = "Ravi";
        }
        public void ModifyDoctor()
        {
            DoctorId = 2000;
            DoctorName = "Amogh";
        }
        public void DisplayDoctorDetails()
        {
            Console.WriteLine($"Doctor Id:"+DoctorId +"\n" +"Doctor Name:"+DoctorName +"\n");
        }

        public void BookApp(int did, string pname)
        {
            Console.WriteLine($"Booked appointment for {DoctorName} with Doctor Id {DoctorId}");
        }

        public void DelApp(string pname)
        {
            Console.WriteLine($"Cancelled appointment for {pname}");
        }
    }
}
