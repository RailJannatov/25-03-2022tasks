using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_03_2022
{
    class Employee:Person
    {
        public double SalaryOfDay;
        public double WorkHour;
        bool isForbidden = false;
        public Employee(string name , string surname , int age , double salaryOfDay , double workhour):base(name , surname , age)
        {
            if (salaryOfDay < 250/30 || workhour > 8*30)
            {
                Console.WriteLine("Mumkun deyil");
                isForbidden = true;
                return;
            }
            SalaryOfDay = salaryOfDay;
            WorkHour = workhour;
        }

        public void SalaryCalculator()
        {
            if(isForbidden || Forbid)
            {
                Console.WriteLine("Hesablana bilmez!!!");
                return;
            }
            Console.WriteLine($"Name : {name} Surname : {surname} Age : {age} Salary : {SalaryOfDay*WorkHour}");
        }


    }
}
