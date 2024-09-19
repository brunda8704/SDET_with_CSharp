using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order
    {
        public Order(string? orderDate, double totalCost)
        {
            OrderDate = orderDate;
            TotalCost = totalCost;
        }

        public string? OrderDate { get; set; }
        public double TotalCost { get; set; }

        public void OrderConfirmed()
        {
            Console.WriteLine("Order Date :" + OrderDate);
            Console.WriteLine("Total Cost :" + TotalCost);
        }



    }
}
