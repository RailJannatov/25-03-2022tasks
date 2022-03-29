using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double TotalIncome;

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;

        }
        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
                Console.WriteLine($"gelir {TotalIncome}  say {Count}");
            }
            else
            {
                Console.WriteLine("mehsul movcud deyil!!!");
            }
        }
    }

}
