using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Product
    {
        public int ProductID {  get; set; }
        public string? Name { get; set; }
        public double Price {  get; set; }
        public int StockQuantity {  get; set; }

        public static void AddProduct(DigitalProduct product)
        {
            if (product.ProductID <= 0)
            {
                throw new OrderException(MyException.ErrorMessages["Error1"]);
            }
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new OrderException(MyException.ErrorMessages["Error2"]);
            }
        }
        public static void AddProduct1(PhysicalProduct product)
        {
            if (product.ProductID <= 0)
            {
                throw new OrderException(MyException.ErrorMessages["Error1"]);
            }
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new OrderException(MyException.ErrorMessages["Error2"]);
            }
        }
    }
}
