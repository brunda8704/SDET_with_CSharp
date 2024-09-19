using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel:TourismDestination1
    {
        public Hotel(string? name, string? location, int rating, double pricePerNight,string? hotelName,int availableRooms) 
            : base(name, location, rating, pricePerNight)
        {
            HotelName = hotelName;
            AvailableRooms = availableRooms;
        }

        public string? HotelName {  get; set; }
        public int AvailableRooms {  get; set; }

        public async Task BookRooms(int requestedRoom,string? hotelName)
        {
            if (requestedRoom <= AvailableRooms)
            {
                Console.WriteLine($"Booking hotel {HotelName}.....");
                await Task.Delay(3000);
                AvailableRooms = AvailableRooms - requestedRoom;
                Console.WriteLine($"Booking confirmed: booked {requestedRoom} rooms in {HotelName} hotel.");
            }
            else
            {
                Console.WriteLine($"Sorry, insufficient rooms availabile in {HotelName} hotel");

            }
            Console.WriteLine($"Current availability in {HotelName}: {AvailableRooms} rooms\n.");
        }
    }
}
