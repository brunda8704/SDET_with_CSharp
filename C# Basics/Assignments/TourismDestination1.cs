using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination1
    {
        public TourismDestination1(string? name, string? location, int rating, double pricePerNight)
        {
            Name = name;
            Location = location;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public static List<TourismDestination1> tourismDestination1s=new List<TourismDestination1>();
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int Rating { get; set; }
        public double PricePerNight {  get; set; }

        public static void QueryMethod()
        {
            var topRated = tourismDestination1s.FindAll(x => x.Rating >= 4);
            if(topRated!=null)
            {
                Console.WriteLine("Top rated destination details(rating>=4):\n");
                foreach (var item in topRated)
                {
                    Console.WriteLine("Name:" + item.Name + " " + "Location:"+item.Location+" "+"Rating:"+item.Rating+" "+"Price per night:"+item.PricePerNight);
                }
            }
            else 
            {
                Console.WriteLine("No destination found");
            }


            var priceRate = tourismDestination1s.OrderBy(x => x.PricePerNight);
            Console.WriteLine("\nSorting destination price per night:\n");
            foreach (var item in priceRate)
            {
                Console.WriteLine("Name:" + item.Name + " " + "Location:" + item.Location + " " + "Rating:" + item.Rating + " " + "Price per night:" + item.PricePerNight);
            }

            var location1 = tourismDestination1s.FindAll(x=>x.Location=="Kerala");
            Console.WriteLine("\nFinding destination based on location(location=kerala):\n");
            foreach (var item in location1)
            {
                Console.WriteLine("Name:" + item.Name + " " + "Location:" + item.Location + " " + "Rating:" + item.Rating + " " + "Price per night:" + item.PricePerNight);
            }
        }
    }
}
