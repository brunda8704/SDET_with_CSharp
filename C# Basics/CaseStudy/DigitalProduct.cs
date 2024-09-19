using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct:Product,IOrderable
    {
        public static List<DigitalProduct> Products = new List<DigitalProduct>();   
        public string? DownloadLink {  get; set; }
        public string? FileFormat { get; set; }



        public void DeliveringProduct()
        {
            Console.WriteLine("Download link is {0}", DownloadLink);
        }

      

        

        public void PlacingOrder()
        {
            Console.WriteLine("Do you want to continue the order?\n1.yes\n2.no");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                if (StockQuantity > 0)
                    Console.WriteLine("Continue to payment...");
                else
                    Console.WriteLine("Product not available");
            }
            else
            {
                Console.WriteLine("Reverting back");
            }
        }

        public void ProceesingPayment()
        {
            Console.WriteLine("Enter the card details for product {0}", Name);
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine("Payment successful");
            }
        }

        
    }
}
