using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public int CustomerId {  get; set; }
        public string? CustomerName { get; set; }
        public long PhoneNumber {  get; set; }
        public double Balance {  get; set; }

        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() { CustomerId=100, CustomerName="Maria", PhoneNumber=9856467551, Balance=20000 },
            new Customer() { CustomerId=106, CustomerName="Anu", PhoneNumber=8746356677, Balance=50000 },
            new Customer() { CustomerId=105, CustomerName="Ajay", PhoneNumber=9475874668, Balance=80000 },
        };

        public void InputPhoneNumber(long phoneNumber)
        {

           var found=customers.Find(x=>x.PhoneNumber == phoneNumber);
            if (found != null)
            { 
                    Console.WriteLine("\nCustomer Name:"+found.CustomerName);
                    Console.WriteLine("Balance:"+found.Balance);   
            }
            else
            {
                Console.WriteLine("No customer found with this phone number\n");
            }

        }

        public void DisplayCustomer()
        {
            Console.WriteLine("***Customer Details***\n");
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer id:" + customer.CustomerId + "\n" + "Customer Name:" + customer.CustomerName + "\n" + "Phone Number:" + customer.PhoneNumber + "\n" + "Balance:" + customer.Balance);
                Console.WriteLine();
            }
        }
    }
}
