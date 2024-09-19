using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class PhysicalProduct:Product,IOrderable
    {
        public static List<PhysicalProduct> Products = new List<PhysicalProduct>();
        public double Weight { get; set; }
        public string? Dimensions {  get; set; }


        public void PlacingOrder()
        {
            Console.WriteLine("Do you want to continue the order\n1.yes\n2.no");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                if (StockQuantity > 0)
                    Console.WriteLine("Continue to payment");
                else
                    Console.WriteLine("Product not available");
            }
            else
            {
                Console.WriteLine("Reverting back");
            }
        }

        public void DeliveringProduct()
        { 
            Console.WriteLine("product is shipped and shipping cost is {0}", Weight * 10);
        }

        public void ProceesingPayment()
        {
            Console.WriteLine("Enter the card details for product {0}", Name);
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine("payment successful");
            }
        }

       
    }
}
