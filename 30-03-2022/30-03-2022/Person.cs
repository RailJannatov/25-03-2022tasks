using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_03_2022
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
        public bool Forbid;

        public Person(string name , string surname , int age)
        {
            if (name == " " || name == "" || surname == " " || surname == "" || age < 18)
            {
                Console.WriteLine("Verilen xareteristikalrda sehv var.");
                Forbid = true;
                return;
            }
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
}
