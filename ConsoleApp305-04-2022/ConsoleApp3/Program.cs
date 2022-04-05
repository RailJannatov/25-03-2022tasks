using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("A", 150, 2);
            Room room2 = new Room("B", 1500, 25);

            Hotel hotel1 = new Hotel("Emerald");

            hotel1.AddRoom(room1,room2);
            Console.WriteLine(hotel1);

            hotel1.MakeReservation(1);
            hotel1.MakeReservation(1);
            
        }
    }
}
