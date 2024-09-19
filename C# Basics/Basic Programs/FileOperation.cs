using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperation
    {
        public void CreateFile()
        {
            FileInfo fileInfo = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            using StreamWriter streamWriter=fileInfo.CreateText();
            Console.WriteLine("File has been created");

            streamWriter.WriteLine("Welcome");
            streamWriter.WriteLine("Hello");
            streamWriter.WriteLine("How u doing?");

        }
        public void WriteData()
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample2.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter= new StreamWriter(fileStream);
            Console.WriteLine("Enter the text which you want to write to the file");
            string? str=Console.ReadLine();
            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        public void ReadData()
        {
            FileStream fileStream1 = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream1);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string str=streamReader.ReadLine();
            while(str != null)
            {
                Console.WriteLine(str);
                str = streamReader.ReadLine();
            }
            streamReader.Close();
            fileStream1.Close();
        }

        public void CopyMoveFile()
        {
            FileInfo fileInfo1 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            FileInfo fileInfo2 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample2.txt");

            fileInfo1.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1\\Sample.txt");
            fileInfo2.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp2\\Sample2.txt");

        }

        public void DeleteFile()
        {
            FileInfo fileInfo = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1\\Sample.txt");
            fileInfo.Delete();
        }

        public void FileProperties()
        {
            FileInfo file = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            Console.WriteLine(file.Name);
            Console.WriteLine(file.CreationTime);
            Console.WriteLine(file.LastAccessTime);
            Console.WriteLine(file.LastWriteTime);
            Console.WriteLine(file.Exists);
            Console.WriteLine(file.Extension);
            Console.WriteLine(file.Length.ToString());
        }
    }
}
