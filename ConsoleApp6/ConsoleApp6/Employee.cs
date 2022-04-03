using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if (!Char.IsLetter(item))
                    {
                        count++;
                    }
                }
                if(count == 0 && Char.IsUpper(value[0]))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Adin ilk herfi ve ya sozlerinde reqem var");
                }
            } 
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if (!Char.IsLetter(item))
                    {
                        count++;
                    }
                }
                if (count == 0 && Char.IsUpper(value[0]))
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Soyadin ilk herfi ve ya sozlerinde reqem var");
                }
            }
        }
        public int Salary {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 250)
                {
                    Console.WriteLine("Maash 250 den ashaghi ola bilmez");
                }
                else
                {
                    _salary = value;
                }
            }
        }
      
    }
}
