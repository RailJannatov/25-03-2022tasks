using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Departament
    {
        public string Name { get; set; }
        public int SalaryLimit { get; set; }
        public Employee[] koleler = new Employee[0];

        public void AddEmployee(Employee kole)
        {
            Array.Resize(ref koleler, koleler.Length + 1);
            koleler[koleler.Length - 1] = kole;
        }
    }
}
