using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HotelEvent
    {
        public HotelEvent(string? eventName, string? eventDate, string? location, int capacity)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
            Capacity = capacity;
        }

        public string? EventName {  get; set; }
        public string? EventDate { get; set; }
        public string? Location {  get; set; }
        public int Capacity {  get; set; }

        public static string EventRegistration(string message)
        {
            return message;
        }
    }
}
