//*********Addition of two numbers**********//
//Console.WriteLine("Enter the two numbers:");
//int firstNumber,secondNumber,Sum;
//firstNumber = Convert.ToInt32(Console.ReadLine());  
//secondNumber = Convert.ToInt32(Console.ReadLine());
//Sum=firstNumber + secondNumber;
//Console.WriteLine("Sum of two numbers=" + Sum);



//*************String Manipulation************//
//string? s1 = "";
//string? s2 = "";
//string? s3 = "";
//s1=Console.ReadLine();
//s2=Console.ReadLine();
//s3 = s1 + "" + s2;
//Console.WriteLine(s3);
//Console.WriteLine(s1.Equals(s2));
//Console.WriteLine(s1.ToUpper());
//Console.WriteLine(s1.ToLower());
//Console.WriteLine(s2.Substring(3));

//string[] s=s3.Split(' ');
//for(int i = 0; i < s.Length; i++)
//    Console.WriteLine(s[i]);


//**************Switch expression******************//
//int x = 1;
//switch (x)
//{
//    case 0:
//        Console.WriteLine("Zero");
//        break;

//    case 1:
//        Console.WriteLine("One");
//        break;

//    default:
//        Console.WriteLine("Invalid");
//        break;
//}



//*************driver*********************//
using Basic_Programs;
using Basic_Programs.ExceptionMessages;
using static Basic_Programs.ExceptionMessages.MyExceptions;

//Calculation calculation = new Calculation();
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//double sum = calculation.Add(firstNumber, secondNumber);
//Console.WriteLine(sum);



//Electricity electricity = new Electricity(); //default constructor
//Electricity electricity= new Electricity(10001,9000,9300,"Raj"); //parameterised constructor
//Console.WriteLine($"Bill Amount=" +electricity.CalculateBill());



//Employee employee = new Employee(101, "Anusha", "IT", 10000);
//Console.WriteLine($"EmpId=" +employee.EmpId);
//Console.WriteLine($"EmpName=" +employee.EmpName);
//Console.WriteLine($"Department=" +employee.Department);
//Console.WriteLine($"Basic pay=" +employee.BasicPay);
//Console.WriteLine($"Net Salary=" +employee.CalculateSalary());
//Console.WriteLine("\nEmpId:{0}\n" + "EmpName:{1}\n" + "Department:{2}\n" + "Basic Pay:{3}", employee.EmpId,employee.EmpName,employee.Department,employee.BasicPay);
//Console.WriteLine("Net salary:{0}" ,employee.CalculateSalary());


//ArraysExample arraysExample = new ArraysExample();
//arraysExample.OneDimensional();
//arraysExample.TwoDimensional();
//arraysExample.JaggedArray();


///StudentMarks studentMarks = new StudentMarks(101,"Ashwin","Mysore");
//StudentGrade studentGrade= new StudentGrade();
//studentGrade.RollNo=100;
//studentGrade.StudentName = "Ashwin";
//studentGrade.City = "Mysore";
//studentGrade.Mark1 = 60;
//studentGrade.Mark2 = 80;
//studentGrade.Mark3 = 90;
//studentGrade.DisplayStudentDetails();
//Console.WriteLine("Total:" + studentGrade.CalculateTotal());
//Console.WriteLine("Average:" + studentGrade.CalculateAverage());
//Console.WriteLine("Grade:" + studentGrade.CalculateGrade());



//Console.Write("1.Teaching Staff\n2.Non-Teaching Staff\n");
//int x=Convert.ToInt32(Console.ReadLine());
//switch(x)
//{
//    case 1:
//        TeachingStaff teachingStaff = new TeachingStaff();
//        teachingStaff.CollegeName = "NIE";
//        teachingStaff.StaffId = 100;
//        teachingStaff.Name = "Raj";
//        teachingStaff.Department = "CS";
//        teachingStaff.Specialization = "DBMS,DS";
//        teachingStaff.Semester = 6;
//        teachingStaff.DisplayCollege();
//        teachingStaff.DisplayStaffDetails();
//        teachingStaff.DisplayTeachingStaffDetails();
//        break;

//    case 2:
//        NonTeachingStaff nonTeachingStaff = new NonTeachingStaff();
//        nonTeachingStaff.CollegeName = "GSSS";
//        nonTeachingStaff.StaffId = 104;
//        nonTeachingStaff.Name = "Anu";
//        nonTeachingStaff.Department = "CS";
//        nonTeachingStaff.Responsibilities = "maintaining records";
//        nonTeachingStaff.Experience = 5;
//        nonTeachingStaff.DisplayCollege();
//        nonTeachingStaff.DisplayStaffDetails();
//        nonTeachingStaff.DisplayNonTeachingStaffDetails();
//        break;
//}


//ElectricVehicle electricVehicle = new ElectricVehicle();
//electricVehicle.VehicleNumber = 1;
//electricVehicle.Brand = "Tesla Inc";
//electricVehicle.Model = "X";
//Console.WriteLine($"Type=" + electricVehicle.setTypeOfVehicle()); 

//PetrolVehicle petrolVehicle = new PetrolVehicle();
//petrolVehicle.VehicleNumber = 2;
//petrolVehicle.Brand = "BMW Group";
//petrolVehicle.Model = "X5";
//Console.WriteLine($"Type=" + petrolVehicle.setTypeOfVehicle());


//Doctor doctor = new Doctor();
//doctor.AddNewDoctor();
//doctor.DisplayDoctorDetails();
//doctor.ModifyDoctor();
//doctor.DisplayDoctorDetails();
//doctor.BookApp(2345, "Arun");
//doctor.DelApp("Arun");

//BankDetails bankDetails=new BankDetails(1002,7648389294L,"Ajay","Inactive");
//BankDetails bankDetails = new BankDetails(1234, 56786367L, "Arun");
//BankDetails bankDetails = new BankDetails();
//BankDetailsNew bankDetailsNew=new BankDetailsNew(1002, 7648389294L, "Ajay", "Inactive");
//bankDetailsNew.WelcomeMessage();
//Console.Write("1.Customer Id\n2.Account Number\n3.Name\n");
//int choice=Convert.ToInt32(Console.ReadLine());
//switch(choice)
//{
//    case 1:
//        Console.WriteLine("Enter customer Id:");
//        bankDetailsNew.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
//        break;
//    case 2:
//        Console.WriteLine("Enter Account Number:");
//        bankDetailsNew.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
//        break;
//    case 3:
//        Console.WriteLine("Enter Name:");
//        bankDetailsNew.GetAccountDetails(Console.ReadLine());
//        break;
//    default:
//        Console.WriteLine("Invalid choice!!");
//        break;

//}
//BankDetailsNew.ExitMessage();


//NonGenericCollection nonGenericCollection = new NonGenericCollection();
//nonGenericCollection.ArrayListHandling();
//nonGenericCollection.StackHandling();
//nonGenericCollection.QueueHandling();
//nonGenericCollection.HashTableHandling();
//nonGenericCollection.SortedListHandling();

//GenericCollection genericCollection = new GenericCollection();
//genericCollection.ListHandling();
//genericCollection.StackHandling();
//genericCollection.QueueHandling();
//genericCollection.SortedListHandling();
//genericCollection.DictionaryHandling();


//ExceptionHandling exceptionHandling= new ExceptionHandling(10,100);
//try
//{
//    exceptionHandling.NumberCheck();
//}
//catch (NumberOneException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    exceptionHandling.NumberCheckOne();
//}
//catch (NumberTwoException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    exceptionHandling.NumberCheck();
//}
////catch(ArgumentException)
////{
////    Console.WriteLine(MyExceptions.exceptionList[3]);
////}
//catch(ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    exceptionHandling.NumberCheckOne();
//}
////catch(ArgumentException)
////{
////    Console.WriteLine(MyExceptions.exceptionList[3]);
////}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    exceptionHandling.Divide();
//}
//catch (ArithmeticException ex)
//{
//    //Console.WriteLine(ex.Message);
//    //Console.WriteLine(ex.StackTrace);
//    //Console.WriteLine(ex.Source);
//    Console.WriteLine(MyExceptions.exceptionList[0]);

//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(MyExceptions.exceptionList[1]);
//}
//catch (Exception ex)
//{
//    //Console.WriteLine(ex.Message);
//    Console.WriteLine(MyExceptions.exceptionList[2]);
//}
//finally
//{
//    Console.WriteLine("Done");
//}

//FileOperation fileOperation = new FileOperation();
//fileOperation.CreateFile();
//fileOperation.WriteData();
//fileOperation.ReadData();
//fileOperation.CopyMoveFile();
//fileOperation.DeleteFile();
//fileOperation.FileProperties();


//GenericsExample<int> g1 = new GenericsExample<int>(10, 20);
//Console.WriteLine(g1.Val1 + " " +g1.Val2);

//GenericsExample<double> g2 = new GenericsExample<double>(23.56, 56.89);
//Console.WriteLine(g2.Val1 + " " +g2.Val2);

//GenericsExample<string> g3 = new GenericsExample<string>("AAA", "BBB");
//Console.WriteLine(g3.Val1 + " "+g3.Val2);

//GenericsExample<int> generics=new GenericsExample<int>(new int[3] {1,2,3});
//generics.Display();

//static void Swap<T>(ref T num1, ref T num2)
//{
//    T temp;
//    temp = num1;
//    num1 = num2;
//    num2 = temp;

//}
//int n1 = 40, n2 = 60;
//char c1= 'a',c2='b';
//Swap<int>(ref n1,ref n2);
//Swap<char>(ref c1,ref c2);
//Console.WriteLine("n1={0},n2={1}",n1,n2);
//Console.WriteLine("c1={0},c2={1}", c1, c2);


public delegate void Delegate1(string message);
public delegate void Delegate2(int num1,int num2);
public delegate int Delegate3(int num1, int num2);
class Program
{
    public static void Main(string[] args)
    {
        Delegate1 delegate1 = DelegateExample.MethodA;
        delegate1("HIII");

        DelegateExample delegateExample = new();

        Delegate2 delegate2 = delegateExample.Add;
        delegate2(10, 20);

        Delegate2 delegate21 = delegateExample.Subtract;
        delegate21(10,20);

        Delegate3 delegate3 = delegateExample.AddWithReturn;
        Console.WriteLine(); delegate3(10,20);


        //Multicast delegates
        Console.WriteLine("Multicast delegate");
        Delegate2 all = delegate2 + delegate21;
        all(1, 2);
    }
}



