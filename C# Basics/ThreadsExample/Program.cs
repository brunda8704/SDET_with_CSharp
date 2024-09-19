//Thread thread1 = new Thread(T1);
//Thread thread2 = new Thread(T1);

//// Start the threads
//thread1.Start();
//thread2.Start();

//// Wait for the threads to finish
//thread1.Join();
//thread2.Join();

//Console.WriteLine("Both threads have completed their work.");

//static void T1()
//{
//    for (int i = 1; i <= 5; i++)
//    {
//        Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is working: " + i);
//        Thread.Sleep(100); // Simulate some work
//    }
//}


//using ThreadsExample;

//Warehouse warehouse = new Warehouse();

//Thread worker1 = new Thread(() => warehouse.AddBox(1));
//Thread worker2 = new Thread(() => warehouse.AddBox(2));

//worker1.Start();
//worker2.Start();

//worker1.Join();
//worker2.Join();

//Console.WriteLine("Work completed. Total boxes in the warehouse: " + warehouse.GetTotalBoxes());



//CourseRegistration courseRegistration = new CourseRegistration();
//int numberOfStudents = 5;

//List<Thread> studentThreads= new List<Thread>();
//for (int i = 1; i <= numberOfStudents; i++)
//{
//    string studentName = $"Student{i}";
//    Thread studentThread= new 
//        Thread(()=>courseRegistration.RegisterStudent(studentName));
//    studentThreads.Add(studentThread);
//    studentThread.Start();

//}
//foreach (Thread thread in studentThreads)
//{
//    thread.Join();
//}
//Console.WriteLine($"Course registration completed. Total registered students:{courseRegistration.GetRegisteredStudentCount()}");

//class Programs
//{
//    static async Task Main()
//    {
//        Console.WriteLine("Starting asynchronous operation...");
//        await PerformAsyncOperation();
//        Console.WriteLine("Asynchronous operation completed.");
//    }
//    static async Task PerformAsyncOperation()
//    {
//        await Task.Delay(2000);
//        Console.WriteLine("Async operation completed.");

//    }
//}



using System;

class Program
{
    static async Task Main()
    {
        List<string> urls = new List<string>
        {
            "https://www.google.com",
             "https://www.microsoft.com",
              "https://www.yahoo.com",

        };
        Console.WriteLine("Downloading web pages asynchronously...");
        List<Task<string>> tasks = new List<Task<string>>();
        foreach (string url in urls)
        {
            tasks.Add(DownloadWebPageAsync(url));
        }
        await Task.WhenAll(tasks);
        foreach (Task<string> task in tasks)
        {
            string content = await task;
            Console.WriteLine($"Downloaded {content.Length} bytes from a web page");
        }
    }

    static async Task<string>DownloadWebPageAsync(string url)
    {
        using(HttpClient client = new HttpClient())
        {
            string content = await client.GetStringAsync(url);
            return content;
        }
    }
}

