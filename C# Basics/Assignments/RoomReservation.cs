using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
        public static List<T> reservationList= new List<T>();
        public void BookRoom(T Room)
        {
            reservationList.Add(Room);
            Console.WriteLine("Room booked successfully!!!");
        }
        public void CancelRoom(T Room)
        {
            reservationList.Remove(Room);
            Console.WriteLine("Room cancelled successfully!!!");
        }
    }
}
