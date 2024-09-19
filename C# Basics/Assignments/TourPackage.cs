using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourPackage
    {
        public TourPackage(int packageID, string? destination, string? startDate, double price)
        {
            PackageID = packageID;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public int PackageID {  get; set; }
        public string? Destination { get; set; }
        public string? StartDate { get; set; }
        public double Price {  get; set; }

        public static List<TourPackage> tourPackages=new List<TourPackage>();   

        public static void ReservePackage()
        {
            Console.Write("enter package id:");
            int pID=Convert.ToInt32(Console.ReadLine());    
            lock(tourPackages)
            {
                var found=tourPackages.Find(x=>x.PackageID==pID);
                if (found!=null)
                {
                    Console.WriteLine($"Package details:\nPackage Id:{found.PackageID}, Destination:{found.Destination}, Start date:{found.StartDate}, Price:{found.Price}\n");
                }
                else
                {
                    Console.WriteLine("Package Id not available");
                }
            }
        }

    }
}
