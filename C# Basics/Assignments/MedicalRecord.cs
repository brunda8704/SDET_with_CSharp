using Assignments.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord:Patient
    {
        public int RecordId { get; set; }
        public double TreatmentCost {  get; set; }  

        public static List<MedicalRecord> medicalRecords = new List<MedicalRecord>();

        public void AddMedicalRecord(int Id, string Name, int Age, string Diagnosis, int RecordId, double TreatmentCost)
        {
            if ((string.IsNullOrEmpty(Name)) || string.IsNullOrEmpty(Diagnosis))
            {
                throw new InvalidPatientDataException(MyException.ErrorMessages["Error4"]);
            }
            else if(TreatmentCost<0)
            {
                throw new InvalidMedicalRecordException(MyException.ErrorMessages["Error5"]);
            }
            else
            {
                medicalRecords.Add(new MedicalRecord { Id = Id, Name = Name, Age = Age, Diagnosis = Diagnosis, RecordId = RecordId, TreatmentCost = TreatmentCost });
            }
        }

        public static void Display()
        {
            Console.WriteLine("Medical Record");
            foreach (var item in medicalRecords)
            {
                Console.WriteLine("Id:" + item.Id + "\n" + "Name:" + item.Name + "\n" + "Age:" + item.Age + "\n" + "Diagnosis:" + item.Diagnosis +"\n" +"Record id:"+item.RecordId +"\n" +"Treatment cost:"+item.TreatmentCost);
            }
        }
    }
}
