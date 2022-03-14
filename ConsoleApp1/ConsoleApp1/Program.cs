using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //second task
            int[] array = { 4, 3, 7, 13, 26, 15 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("cutlerin indexi:" + i);
                }
                else if (array[i] % 2 == 1)
                {
                    Console.WriteLine($"{i}teklerin indexi: ");
                }
            }



            //third task
            int number = 2;
            int resultnum = 32;
            int handlenum = 1;
            int i = 0;
            int count = 1;
            for (i = 0; handlenum < resultnum; i++)
            {
                handlenum = handlenum * number;
                count++;
            }
            Console.WriteLine(resultnum + " 2-nin " + i + "-ci dereceden quvvetidir");

            //fourth task
            int num = 12345;
            int counter=0;

            for (int i = 0; num>0; i++)
            {
                num = num / 10;
                counter++;
                
            }
            Console.WriteLine(counter);

        }
        }
}
