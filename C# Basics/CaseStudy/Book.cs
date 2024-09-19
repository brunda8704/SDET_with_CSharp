using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Book:BookType
    {
        public Book(string? title, string? author, double? iSBN, double price, string? availability,string? type)
            : base(type)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Price = price;
            Availability = availability;
            
        }

        public string? Title {  get; set; }
        public string? Author { get; set; }
        public double? ISBN { get; set; }
        public double Price { get; set; }
        public string? Availability {  get; set; }

        
        public void Display(Book book)
        {
            Console.WriteLine("\nBook Details:");
            Console.WriteLine($"Title:" + Title + "\n" + "Author:" + Author + "\n" +
                "ISBN:" + ISBN + "\n" + "Price:" + Price + "\n" + "Availability:" + Availability);

        }
    }
}
