using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Room
    {
        
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int PersonCapacity { get; set; }

        public bool isAvailable { get; set; } = true;

        
        public Room(string name, double price, int personcapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
            _id++;
            Id = _id;
        }

        public string ShowInfo()
        {
            return $"Id : {Id}\nName :{Name}\nPrice : {Price}\nPerson Capacity : {PersonCapacity}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
