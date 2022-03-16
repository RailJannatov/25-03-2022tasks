using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Divide(50, 5));
            //Repeat("HA", 5);
            Pover(24);

        }
        #region FirstTask
        //static int Divide(int firstNumber,int secondNumber)
        //{
        //    return firstNumber / secondNumber;
        //}
        #endregion

        #region SecondTask
        //static void Repeat(string text,int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.Write(text);
        //    }
        //}
        #endregion

        #region ThirdTask

        static int Count(string text, char symbol)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    count++;
                }

            }
            return count;
        }
        #endregion
        #region FourthTask
        static void Pover(int num1, int num2 = 2)
        {
            int holder = num2;
            int quvvet = 1;
            for (int i = 0; holder < num1; i++)
            {
                holder = holder * num2;
                quvvet++;
            }
            if (num1 == 1)
            {
                quvvet = 0;
            }
            if (num1 % holder != 0)
            {
                Console.WriteLine("eded misil deyil");
            }
            else
            {
                Console.WriteLine(quvvet);
            }
        }
        #endregion
    }
}
