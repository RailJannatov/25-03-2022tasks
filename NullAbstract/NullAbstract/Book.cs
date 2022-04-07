using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAbstract
{
    class Book:Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name , double price , int count , string authorName , int pagecount):base(name , price , count)
        {
            AuthorName = authorName;
            PageCount = pagecount;
        }

        public override void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nAuthor : {AuthorName}\nId : {Id}");
        }
    }
}
