using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emish = new Employee();
            Emish.Name = "Emilia";
            Emish.Salary = 280;
            Emish.Surname = "Aghayeva";
            Employee Murad = new Employee();
            Murad.Name = "Murad";
            Murad.Surname = "Abdullazade";
            Murad.Salary = 380;
            

            Departament developerLab = new Departament();
            developerLab.AddEmployee(Emish);
            developerLab.AddEmployee(Murad);
            foreach(var kole in developerLab.koleler)
            {
                Console.WriteLine($"{kole.Name} {kole.Salary}{kole.Surname} ilin ishchisi sechildi bonus kimi CEO gorush teyin olunub");
            }
        }
    }
}
