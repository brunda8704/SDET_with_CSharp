using Assignments;
using Assignments.ExceptionMessages;
using System.Reflection;
using System.Runtime.CompilerServices;
using static Assignments.ExceptionMessages.MyException;
//18/10/2023           
//Student student = new Student("RajKumar", 50, 80, 40);
//Console.WriteLine($"Total=" +student.Total());
//Console.WriteLine($"Average=" +student.CalculateAverage());
//Console.WriteLine($"Grade=" + student.Grade());

//19/10/2023
//Product[] products = new Product[3];
//products[0] = new Product("Bread", 50, 2);
//products[1] = new Product("Milk",30,1);
//products[2] = new Product("Jam",80,1);
//Console.WriteLine("Product details");
//Console.WriteLine("***************\n");
//foreach (var item in products)
//{
//    Console.WriteLine("Product Name:" +item.ProductName);
//    Console.WriteLine("Price:" +item.Price);
//    Console.WriteLine("Quantity:" + item.Quantity);
//    Console.WriteLine("Total value:"+ item.ProductValue());
//    Console.WriteLine();
//}


//Students[] students = new Students[]
//{
// new Students("Ajay","C", new int[] {50,40,80}),
// new Students("Sanjana","B", new int[] {70,60,80}),
// new Students("Anu","A", new int[] {90,70,80})
//};

//Console.WriteLine("Student details");
//Console.WriteLine("***************");
//foreach (var student in students)
//{
//    Console.WriteLine("Student Name:" +student.Name);
//    double[] marks = new double[3];
//    double total = 0;
//    Console.Write("Marks:");
//    for (int i = 0;i<marks.Length;i++)
//    {
//        marks[i] = student.Marks[i];
//        total = total + marks[i];
//        Console.Write(marks[i] + " ");
//    }
//    Console.WriteLine("\nTotal:" +total);
//    Console.WriteLine("Average:" + student.CalculateAverage());
//    Console.WriteLine("Grade:" + student.Grade);
//    Console.WriteLine(student.GetMarksSummary());
//}

//20/10/2023
//Single
//ElectronicsProduct electronicsProduct = new ElectronicsProduct("TV",10000,2,1);
////Console.WriteLine($"Product Name:" +electronicsProduct.ProductName 
////    + "\n" +"Price:" +electronicsProduct.Price +"\n" +"Quantity:"+electronicsProduct.Quantity);
//electronicsProduct.DisplayElectronicsProduct();
//Console.WriteLine(electronicsProduct.ProductValue()); 

////Multi-level
//DigitalProduct digitalProduct = new DigitalProduct("Mobile", 50000, 5, 6, "Mp3");
////Console.WriteLine($"Product Name:" + digitalProduct.ProductName
////    + "\n" + "Price:" + digitalProduct.Price + "\n" + "Quantity:" + digitalProduct.Quantity);
//digitalProduct.DisplayDigitalProduct();
//digitalProduct.DisplayElectronicsProduct();
//Console.WriteLine(digitalProduct.ProductValue());


////heirarchial
//ElectronicsProduct electronicsProduct1 = new ElectronicsProduct("TV", 10000, 2, 1);
//ClothingProduct clothingProduct = new ClothingProduct("T-shirt", 2500, 5, "Large");
//DigitalProduct digitalProduct1 = new DigitalProduct("Mobile", 50000, 5, 6, "Mp3");
////Console.WriteLine($"\nProduct Name:" + clothingProduct.ProductName
////    + "\n" + "Price:" + clothingProduct.Price + "\n" + "Quantity:" + clothingProduct.Quantity);
//clothingProduct.DisplayClothingProduct();
//Console.WriteLine(electronicsProduct1.ProductValue());
//Console.WriteLine(digitalProduct1.ProductValue());
//Console.WriteLine(clothingProduct.ProductValue());


//23/10/2023
//Console.Write("enter first name:");
//string firstName = Console.ReadLine();
//Console.Write("enter last name:");
//string lastName = Console.ReadLine();
//Console.Write("enter age:");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.Write("enter employee id:");
//int id = Convert.ToInt32(Console.ReadLine());
//Employee employee = new Employee(firstName, lastName, age, id);
//employee.DisplayInfo(age);

//Console.Write("enter radius:");
//double radius = Convert.ToDouble(Console.ReadLine());
//Circle circle = new Circle(radius);
//circle.Draw();
//circle.CalculateArea();
//circle.CalculatePerimeter();

//Console.Write("enter length:");
//double length = Convert.ToDouble(Console.ReadLine());
//Console.Write("enter width:");
//double width = Convert.ToDouble(Console.ReadLine());
//Rectangle rectangle = new Rectangle(length, width);
//rectangle.Draw();
//rectangle.CalculateArea();
//rectangle.CalculatePerimeter();


//25/10/2023
//InsurancePolicy insurancePolicy = new InsurancePolicy("Bhima", 723748555, 10000);
//insurancePolicy.RenewPolicy(20000);
//insurancePolicy.RenewPolicy();

//LifeInsurance lifeInsurance = new LifeInsurance("Gold", 84746563, 500000, 18);
////Console.WriteLine(lifeInsurance.CalculatePremium());
//CarInsurance carInsurance = new CarInsurance("Bheema", 764846884, 300000, "Petrol");
//Console.WriteLine(carInsurance.CalculatePremium());


//26/10/23
//Customer customer=new Customer();
//Console.WriteLine("enter phone number");
//long phoneNumber=Convert.ToInt64(Console.ReadLine());
//customer.InputPhoneNumber(phoneNumber);
//customer.DisplayCustomer();

//CallRecord callRecord = new CallRecord();
//Console.WriteLine("enter phone number");
//long phoneNumber = Convert.ToInt64(Console.ReadLine());
//callRecord.CallHistory(phoneNumber);
//callRecord.TotalNoOfCalls();

//Patient patient = new Patient();
//try
//{
//    //patient.AddPatient(1, "Harini", 150, "Sugar");
//    //patient.AddPatient(2, "", 34, "BP");
//    //patient.AddPatient(3, "John", 67, "");
//    patient.AddPatient(4, "Tom", 78, "Thyroid");
//    Patient.Display();


//}
//catch (CustomException ex)
//{
//    Console.WriteLine(ex.Message);
//}


//27/10/2023
//MedicalRecord medicalRecord = new MedicalRecord();
//try
//{
//    medicalRecord.AddMedicalRecord(10,"Arun", 23, "Thyroid", 455, 3000);
//    MedicalRecord.Display();
//}
//catch(InvalidPatientDataException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch(InvalidMedicalRecordException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Patient patient = new Patient();
//int option = 1;
//do
//{
//   Console.WriteLine("****Patient Details***");
//Console.WriteLine("1.Add patient records");
//Console.WriteLine("2.View patient records");
//Console.WriteLine("3.Exit program");
//int choice=Convert.ToInt32(Console.ReadLine());


//    switch (choice)
//    {
//        case 1:
//            patient.AddPatientToFile(4, "Tom", 78, "Thyroid");
//            break;
//        case 2:
//            patient.ViewPatientDataFromFile();
//            break;
//        case 3:
//            Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;

//    }
//    Console.WriteLine("Do you want to continue?\n1.Yes\n2.No\n");
//    option = Convert.ToInt32(Console.ReadLine());
//}
//while (option != 2);


//MedicalHistory medicalHistory = new MedicalHistory();
//    int option = 1;
//do
//{
//    Console.WriteLine("****Medical Record***");
//    Console.WriteLine("1.Add records");
//    Console.WriteLine("2.View record for a specific patient");
//    Console.WriteLine("3.Exit program");
//    int choice = Convert.ToInt32(Console.ReadLine());


//    switch (choice)
//    {
//        case 1:
//           medicalHistory.AddRecordToFile(100,12,"Diabetis","November 23");
//            break;
//        case 2:
//            //medicalHistory.ViewRecordFromFile();
//            break;
//        case 3:
//            Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;

//    }
//    Console.WriteLine("Do you want to continue?\n1.Yes\n2.No\n");
//    option = Convert.ToInt32(Console.ReadLine());
//}
//while (option != 2);


//30/10/2023
//Console.WriteLine("*****Room reservation system*****\n");
//Console.Write("enter room number:");
//int roomNumber=Convert.ToInt32(Console.ReadLine());
//Console.Write("enter room type(Single/Double):");
//string? roomType=Console.ReadLine();
//HotelRoom hotelRoom=new HotelRoom(roomNumber, roomType,true);
//RoomReservation<HotelRoom> roomReservation = new RoomReservation<HotelRoom>();
//roomReservation.BookRoom(hotelRoom);
//Console.WriteLine("\nDetails of room:");
//foreach (var item in RoomReservation<HotelRoom>.reservationList)
//{
//    Console.WriteLine("Room number:"+roomNumber +"\n"+ "Room type:"+roomType);
//}
//Console.Write("\nenter room number:");
//int roomNumber1 = Convert.ToInt32(Console.ReadLine());
//HotelRoom found=RoomReservation<HotelRoom>.reservationList.Find(x=> x.RoomNumber == roomNumber1);
//if(found==null)
//{
//    Console.WriteLine("No room found to cancel");
//}
//else
//{
//    roomReservation.CancelRoom(found);



//31/10/2023
//class Program
//{
//    public delegate decimal BonusCalculation(Employees employees);

//    public static void Main(string[] args)
//    {

//        Console.Write("enter employee id:");
//        int id = Convert.ToInt32(Console.ReadLine());
//        Console.Write("enter employee name:");
//        string? name = Console.ReadLine();
//        Console.Write("enter performane rating(1to5):");
//        int rating = Convert.ToInt32(Console.ReadLine());
//        Employees employees = new Employees(id, name, rating);
//        employees.AddEmployee(employees);

//        Console.Write("\nChoose option for bonus calculation:\n1.Performance threshold\n2.Department Specific\n3.Exit\n");
//        int option = Convert.ToInt32(Console.ReadLine());
//        switch (option)
//        {
//            case 1:
//                BonusCalculation bonusCalculation = employees.PerformanceBasedBonus;
//                Console.WriteLine("Bonus:"+bonusCalculation(employees));
//                break;
//            case 2:
//                BonusCalculation bonusCalculation1 = employees.DepartmentSpecificBonus;
//                Console.WriteLine("Bonus:" + bonusCalculation1(employees));
//                break;
//            case 3:
//                Environment.Exit(0);
//                break;
//            default:
//                Console.WriteLine("Invalid choice");
//                break;
//        }

//    }
//}

//class Program
//{
//    public delegate string EventNotification(string message);
//    public static void Main(string[] args)
//    {
//        HotelEvent hotelEvent = new HotelEvent("Live concert", "23/11/2023", "Mumbai", 50);
//        EventNotification eventNotification = HotelEvent.EventRegistration;
//        if(eventNotification == null )
//        {
//            Console.WriteLine(eventNotification("Not registered"));
//        }
//        else
//        {
//            Console.WriteLine(eventNotification($"Event {hotelEvent.EventName} is registered successfully for date {hotelEvent.EventDate}"));
//        }
//    }
//}




//TourismDestination tourism1 = new TourismDestination("Batu Caves", "Malaysia", 4);
//TourismDestination tourism2 = new TourismDestination("Taj Mahal", "India", 2);
//TourismDestination tourism3 = new TourismDestination("Marina Bay", "Singapore", 3);
//TourismDestination.tourismDestinations.Add(tourism1);
//TourismDestination.tourismDestinations.Add(tourism2);
//TourismDestination.tourismDestinations.Add(tourism3);
//TourismDestination.SortingBasedOnRating();


//TourismDestination1 tourism1 = new TourismDestination1("Ooty", "Tamilnadu", 4, 2500);
//TourismDestination1 tourism2 = new TourismDestination1("Yaana", "Karnataka", 2, 5000);
//TourismDestination1 tourism3 = new TourismDestination1("Varkala", "Kerala", 3, 4000);
//TourismDestination1 tourism4 = new TourismDestination1("Ramoji Film City", "Hyderabad", 5, 6000);

//TourismDestination1.tourismDestination1s.Add(tourism1);
//TourismDestination1.tourismDestination1s.Add(tourism2);
//TourismDestination1.tourismDestination1s.Add(tourism3);
//TourismDestination1.tourismDestination1s.Add(tourism4);
//TourismDestination1.QueryMethod();



//01/11/2023

//class Program
//{

//    static async Task Main(string[] args)
//    {

//        Hotel hotel1 = new Hotel("Ooty", "Tamilnadu", 4,2500, "Ginger", 15);
//        Hotel hotel2 = new Hotel("Yaana", "Karnataka", 2, 5000,"Amigooz",30);
//        Hotel hotel3 = new Hotel("Varkala", "Kerala", 3, 4000,"Flamingoo",20);

//        await hotel1.BookRooms(16, "Ginger");
//        await hotel2.BookRooms(10, "Amigooz");
//        await hotel3.BookRooms(6, "Flamingoo");

//    }

//}


//TourPackage tour1 = new TourPackage(23, "Kodikanal", "25/11/2023", 3400);
//TourPackage tour2 = new TourPackage(24, "Munnar", "22/12/2023", 4000);

//TourPackage.tourPackages.Add(tour1);
//TourPackage.tourPackages.Add(tour2);

//Thread thread = new Thread(TourPackage.ReservePackage);
//Thread thread1 = new Thread(TourPackage.ReservePackage);
//thread1.Start();
//thread1.Join();
//thread.Start();


//03/11/2023
//TaskItem task=new TaskItem();
//while(true)
//{
//    Console.WriteLine("\n*****To-Do List*****");
//    Console.WriteLine("1.Add task");
//    Console.WriteLine("2.Remove task");
//    Console.WriteLine("3.Mark task as completed");
//    Console.WriteLine("4.Display task");
//    Console.WriteLine("5.Filter completed task");
//    Console.WriteLine("6.Filter pending task");
//    Console.WriteLine("7.Exit");
//    Console.Write("enter your choice:");
//    int choice=Convert.ToInt32(Console.ReadLine()); 

//    switch(choice)
//    {
//        case 1:
//            Console.Write("enter task id:");
//            int taskID=Convert.ToInt32(Console.ReadLine());
//            Console.Write("enter task description:");
//            string? description=Console.ReadLine();
//            task.AddTask(taskID,description,false);
//            break;

//        case 2:
//            Console.Write("enter task id to remove:");
//            int id1=Convert.ToInt32(Console.ReadLine());
//            task.RemoveTask(id1);
//            break;
        
//        case 3:
//            Console.Write("enter task id to mark it as completed:");
//            int id2 = Convert.ToInt32(Console.ReadLine());
//            task.MarkAsCompleted(id2);
//            break;

//        case 4:
//            task.DisplayTask();
//            break;

//        case 5:
//            task.FilterCompletedTask();
//            break;

//        case 6:
//            task.FilterPendingTask();
//            break;

//        case 7:
//            Environment.Exit(0);
//            break; 

//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }
//}
FamilyTree familyTree = new FamilyTree();
FamilyMember grandfather= new FamilyMember("Grand father",70);
FamilyMember father = new FamilyMember("Father", 40);
FamilyMember mother = new FamilyMember("Mother", 30);
FamilyMember child = new FamilyMember("Child", 15);

familyTree.AddMember(grandfather,father);
familyTree.AddMember(grandfather,mother);
familyTree.AddMember(father,child);

Console.WriteLine("Family Tree:");
familyTree.DisplayFamilyMember(grandfather);

