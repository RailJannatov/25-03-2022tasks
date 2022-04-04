using _04_04_2022.Utilities;
using System;


namespace _04_04_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstTask
            //string soz = "Salam";
            //soz.Extension1(6);
            //string vord = "mEhemmed";
            //string vord1 = "sAmir";
            //vord.ToName();
            //vord1.ToNamebySbuilder();
            #endregion
            Console.WriteLine("1: Rectangle sahesini hesabla");
            Console.WriteLine("2: Square sahesini hesabla");
            Console.WriteLine("3: Chxiish");

            int number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Rectangle rectangle = new Rectangle();
                    rectangle.Length = 20;
                    rectangle.Width = 50;
                    rectangle.CalcArea();
                    break;
                case 2:
                    Square square = new Square();
                    square.Side = 5;
                    square.CalcArea();
                    break;
                case 3: Console.WriteLine("Chixish");
                    break;

                default:
                    Console.WriteLine("Bele sechime uyghun sahe yoxdur ");
                    break;
            }



        }
    }
}
