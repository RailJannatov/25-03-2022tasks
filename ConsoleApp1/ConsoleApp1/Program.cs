using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = { 5, 29, 41, 88, 61, 0, 11, 56, 65, 28, 17, 123, 52 };
            //int counter = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //        var handleQaliq = 0;

            //        while (arr[i]>0)
            //        {
            //            var qaliq = arr[i] % 10;
            //            arr[i] /= 10;
            //            handleQaliq += qaliq;
            //        }
            //          if (handleQaliq <= 10)
            //          {
            //        counter++;
            //          }

            //    }

            //Console.WriteLine(counter);



            //int number;
            //int i;
            //dynamic count = 1;

            //for (number = 143; number > 0; number--)
            //{
            //    if (count >= 1)
            //    {
            //        for (i = 1; i * i <= number; i++)
            //        {
            //            if (number == (i * i))
            //            {
            //                count--;
            //                Console.WriteLine(i);
            //                break;
            //            }
            //            else
            //            {
            //                continue;
            //            }
            //        }
            //    }
            //    else { break; }
            //int number = 25;

            //int count = 0;
            //int anotherCount = 0;

            //for (int i = 1; i*i <= number; i++)
            //{

            //        count++;

            //}
            //anotherCount = count++;
            //var anotherRoot = anotherCount * anotherCount;
            //if(anotherRoot-number / count >=8)
            //{

            //}
            //else
            //{

            //}




            //Console.WriteLine(count);













            //1.Arrayde ki, elementlerin ededi ortesini tapmaq.
            //int[] array = { 5, 6, 2, 8, 9 };
            //int sum = 0;

            //for (int i = 0; i <array.Length; i++)
            //{
            //    sum = sum + array[i];
            //}


            //Console.WriteLine(sum / array.Length);

            //2.Arrayda ki,cut elementlerinin cemi ile tek elementlerinin ceminin ferqi
            //int[] arr = { 1, 5, 6, 7, 8 };
            //int sumodd = 0;
            //int sumeven = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        sumeven = sumeven + arr[i];
            //    }
            //    else
            //    {
            //        sumodd += arr[i];
            //    }
            //}
            //Console.WriteLine(sumeven - sumodd);
            //3.Console penceresinde 2 eded daxil edin.
            //            Daxil olunan 2 ededden hansinin boyuk oldugu ekrana yazilsin. 
            //            Eger beraberdirse ekrana beraberdir yazilsin


            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());

            //if (firstNum>secondNum)
            //{
            //    Console.WriteLine($"boyuk olan eded {firstNum} -dir");

            //}
            //else if (firstNum==secondNum)
            //{
            //    Console.WriteLine("beraberdir"+secondNum);
            //}
            //else
            //{
            //    Console.WriteLine($"boyuk olan eded {secondNum} -dir");
            //}

            //4. Console penceresinde 1 eded daxil edin.
            //Daxil olunan ededin tek ve ya cut oldugunu ekrana yazdirin.
            //int input = int.Parse(Console.ReadLine());
            //if(input %2 ==0)
            //{
            //    Console.WriteLine($"input cutdur");
            //}
            //else
            //{
            //    Console.WriteLine("input tekdir");
            //}
            //5.Ededi tersine çeviren alqoritm yazın.
            //Console.WriteLine("Nazakatin xetrine eded daxil edin,please");
            //int num = int.Parse(Console.ReadLine());
            //int rev = 0;
            //for (int i = 0; num > 0; i++)
            //{
            //    rev = rev * 10 + (num % 10);
            //    num /= 10;
            //}


            //Console.WriteLine(rev);

            //6. Iki Arrayimiz var 1ci array-de olan ikincide olmayan ededleri cap eden alqoritm yazın.
            //int[] array1 = { 6, 9, 15, 22 };
            //int[] array2 = { 9, 22, 27 };
            //bool isExist;

            //for(int i = 0; i < array1.Length; i++)
            //{
            //    isExist = false;
            //    for(int j = 0; j < array2.Length; j++)
            //    {
            //        if (array1[i] == array2[j])
            //        {
            //            isExist = true;
            //        }
            //    }

            //    if (!isExist) 
            //    {
            //        Console.WriteLine(array1[i]);
            //    }
            //}
        }





    }
}
