using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Products<T>
    {
        public Products(int productID, string? productName, double price, int quantityInStock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public int ProductID {  get; set; }
        public string? ProductName { get; set; }
        public double Price {  get; set; }
        public int QuantityInStock {  get; set; }

    }
}
