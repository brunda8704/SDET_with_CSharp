using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating { get; set; }

        public static List<TourismDestination> tourismDestinations = new List<TourismDestination>();
        public static void SortingBasedOnRating()
        {

            var sorted=tourismDestinations.OrderByDescending(x => x.Rating);
            foreach (var item in sorted)
            {
                Console.WriteLine("Name:"+item.Name+" "+"Country:"+item.Country+" "+"Rating:"+item.Rating);

            }

        }
    
    }
}
