using System;
using System.Collections.Generic;

namespace _08_04_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Murad = new Person("Murad", "Abdullazade", 19);
            Person Ibrahim = new Person("Ibrahim", "Isgenderov", 20);
            Person ALi = new Person("Ali", "Veliyev", 19);
            Person Gulchin = new Person("Gulchin", "Taghizade", 21);
            Person Fidan = new Person("Fidan", "Memmedova", 19);
            Person Samir = new Person("Samir", "Aliyev", 23);
            Person Rail = new Person("Rail", "Jannatov", 24);

            List<Person> people = new List<Person>();

            people.Add(Murad);
            people.Add(Ibrahim);
            people.Add(ALi);
            people.Add(Gulchin);
            people.Add(Fidan);
            people.Add(Samir);
            people.Add(Rail);


            //var human = people.Find(person => person.Age == 19);
            //Console.WriteLine(human.Name);
            //Console.WriteLine(people.Find(person => person.Age == 19).Name);

            foreach (var item in people.FindAll(gunay=>gunay.Age==19))
            {
                Console.WriteLine(item.Name);
            }
         
        }
    }
}
