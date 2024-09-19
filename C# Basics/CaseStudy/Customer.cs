using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
        public Customer(string? name, int contactDetails, int customerId)
        {
            Name = name;
            ContactDetails = contactDetails;
            CustomerId = customerId;
        }

        public string? Name {  get; set; }
        public int ContactDetails {  get; set; }
        public int CustomerId {  get; set; }

        public void CustDisplay()
        {
            Console.WriteLine("\nCustomer details:");
            Console.WriteLine($"\nName:"+Name +"\n" +"Contact detail:"+ContactDetails +"\n" +"Customer id:"+CustomerId);
        }
    }
}
