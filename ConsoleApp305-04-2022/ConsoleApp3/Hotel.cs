using ConsoleApp3.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Hotel
    {
        public string Name { get; set; }

        private Room[] rooms = new Room[0];

        public Room this[int index]
        {
            get
            {
                if(index > 0 && rooms.Length > 0)
                {
                    return rooms[index];
                }

                else
                {
                    throw new NotAvailableException("bele bir index yoxdur");
                }
                
            }

            set
            {
                if(index > 0 && rooms.Length > 0)
                {
                    rooms[index] = value;
                }
                else
                {
                    throw new NotAvailableException("bele bir index yoxdur");
                }
            }
        }
        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(params Room[] otaq)
        {
            int arrayLength = rooms.Length;
            Array.Resize(ref rooms, arrayLength + otaq.Length);
            int temp = 0;

            for (int i = arrayLength; i < rooms.Length; i++)
            {
                rooms[i] = otaq[temp];
                temp++;
            }

            
        }

        public void MakeReservation(int? number) 
        { 
            if(!(number is null))
            {
                if(!(rooms[(int)number-1] is null))
                {
                    if (rooms[(int)number - 1].isAvailable)
                    {
                        rooms[(int)number - 1].isAvailable = false;
                    }

                    else
                    {
                        throw new NotAvailableException("otaq doludur");
                    }
                }
                else
                {
                    throw new NotAvailableException("bele bir otaq yoxdur");
                }
            }

            else
            {
                throw new NullReferenceException();
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
