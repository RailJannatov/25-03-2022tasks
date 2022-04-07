using EnumİmplicitExplicit.Enum;
using System;

namespace EnumİmplicitExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Exchange(Currency.USD,2000000));
            //Console.WriteLine(Exchange(Currency.Rubl,50000000));
            //Console.WriteLine(Exchange(Currency.TL, 32000));
            //Console.WriteLine(Exchange(Currency.EUR,10000));


            MyList<int> a = new MyList<int>();
            a.AddItem(2);
            a.AddItem(4);

          
     
        }

        //public static double Exchange(Currency currency,double azn)
        //{
        //    switch (currency)
        //    {
        //        case Currency.USD:
        //            return azn * 0.59;
        //        case Currency.Rubl:
        //            return azn * 8.67;
        //        case Currency.TL:
        //            return azn * 46.43;
        //        case Currency.EUR:
        //            return azn * 0.54;
        //        default:
        //            return azn;

        //    }
        //}
     
    }
}
