using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class DigitalProduct:ElectronicsProduct
    {
       
        public DigitalProduct(string productName, double price, int quantity, int warrantyPeriod, string? fileFormat) 
            : base(productName, price, quantity, warrantyPeriod)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            WarrantyPeriod = warrantyPeriod;
            FileFormat = fileFormat;
        }

        public string? FileFormat {  get; set; }

        public void DisplayDigitalProduct()
        {
            Console.WriteLine("File format:" + FileFormat);
        }
    }
}
