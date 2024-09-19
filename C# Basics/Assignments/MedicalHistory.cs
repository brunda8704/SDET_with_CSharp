using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public int RecordId {  get; set; }
        public int PatientId {  get; set; }
        public string Description {  get; set; }
        public string Date { get; set; }

        public static List<MedicalHistory> medicalHistories = new List<MedicalHistory>();   

        public void AddMedicalHistory(int RecordId,int PatientId,string Description,string Date)
        {
            medicalHistories.Add(new MedicalHistory { RecordId = RecordId, PatientId = PatientId, Description = Description, Date = Date });
        }

        public void AddRecordToFile(int RecordId, int PatientId, string Description, string Date)
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\MedicalHistory.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write("Record Id:" + RecordId);
            streamWriter.Write("Patient Id:" + PatientId);
            streamWriter.Write("Description:" + Description);
            streamWriter.Write("Date:" + Date);
            streamWriter.Close();
            fileStream.Close();

        }
        //public void ViewRecordFromFile()
        //{
        //    FileStream fileStream1 = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\MedicalHistory.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader streamReader = new StreamReader(fileStream1);
        //    Console.WriteLine("Enter the patient id");
        //    string patientId = Console.ReadLine();
        //    if()
        //    {
        //        string str=streamReader.ReadLine();
        //        Console.WriteLine(str);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Medical record is not found with this patient id");
        //    }
            
        //    streamReader.Close();
        //    fileStream1.Close();
        //}

    }
}
