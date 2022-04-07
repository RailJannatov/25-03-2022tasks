using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAbstract
{
    abstract class Product
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public static double TotalIncome { get;protected set; }
        public abstract void Sell();
        public abstract void ShowInfo();
        public Product(string name ,double price , int count)
        {
            Id = _id++;
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
