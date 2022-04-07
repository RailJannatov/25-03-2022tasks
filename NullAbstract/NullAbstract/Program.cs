using System;

namespace NullAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Kitab = new Book("A" , 10 , 1,"Elovset" , 100);
            Book Kitab2 = new Book("B" , 15 , 3,"Elovset" , 150);
            Book Kitab3 = new Book("C" , 15 , 3,"Elovset" , 150);
            Library KitabXana = new Library(2);
            KitabXana.AddBook(Kitab2);
            Kitab2.ShowInfo();
            KitabXana.GetBookById(5);
        }
    }
}
