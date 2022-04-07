using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAbstract
{
    class Library
    {
        public int BookLimit { get; set; }
        public Book[] books = new Book[0];
        public Library(int BookLimit)
        {
            this.BookLimit = BookLimit;
        }
        public void AddBook(Book kitab)
        {
            if (books.Length < BookLimit)
            {
                Array.Resize(ref books , books.Length + 1);
                books[^1] = kitab;
            }
            else
            {
                throw new LimitException("Doludur!");
            }
        }

        public void GetBookById(int? BookId)
        {
            bool IsId = false;
            if (BookId != null)
            {
                foreach (var item in books)
                {
                    if (item.Id == BookId)
                    {
                        item.ShowInfo();
                        IsId = true;
                    }
                }
                if (!IsId)
                {
                    Console.WriteLine("Bu Id - e uygun kitab yoxdur!");
                }
            }
            else
            {
                throw new NullReferenceException("Id nulldur!");
            }
        }
    }
}
