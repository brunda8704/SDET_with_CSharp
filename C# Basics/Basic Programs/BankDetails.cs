using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basic_Programs
{
    internal class BankDetails
    {
        //public BankDetails(int customerId, long accountNumber, string? name)
        //{
        //    CustomerId = customerId;
        //    AccountNumber = accountNumber;
        //    Name = name;
        //    Status = "Inactive";
        //}

        public BankDetails(int customerId, long accountNumber, string name, string status)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            Name = name;
            Status = status;
        }
        //public BankDetails()//Default constructor
        //{
        //    CustomerId = 0;
        //    AccountNumber = 0;
        //    Name = "";
        //    Status = "";
        //}
        public int CustomerId {  get; set; }
        public long AccountNumber {  get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome!!");
        }

        public static void ExitMessage()
        {
            Console.WriteLine("Done!!");
        }
        public void GetAccountDetails(int  customerId)
        {
            if(customerId==customerId)
                Console.WriteLine($"Account number:"+AccountNumber +"\n" +"Name:"+Name +"\n"+"Status:"+Status);
            else
                Console.WriteLine("Customer Id does not exist");
        }
        public void GetAccountDetails(long accountNumber)
        {
            if (AccountNumber==accountNumber)
                Console.WriteLine($"Customer Id:" + CustomerId + "\n" + "Name:" + Name + "\n" + "Status:" + Status);
            else
                Console.WriteLine("Account number does not exist");
        }

        public void GetAccountDetails(string name)
        {
            if (Name==name)
                Console.WriteLine($"Customer Id:" + CustomerId + "\n" + "Account Number:" + AccountNumber + "\n" + "Status:" + Status);
            else
                Console.WriteLine("Name does not exist");
        }
    }
}
