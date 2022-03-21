using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        //static int Change(out int num1, int num2)
        //{
        //    num1 = num1 + num2;
        //    num2 = num1 - num2;
        //    num1 = num1 - num2;
        //    num2 = 40;

        //    num1 = 50;
        //    num2 = num1 + num2;
        //    return num1;

        //}
  


        static void Main(string[] args)
        {
            int[] arr = { 4, 5, -3, 6, 7, 60, 4, 6 };
            Svap(arr);

            static void Svap(int[] arr)
            {
                int max = arr[0];
                int min = arr[0];
                int maxindex = 0;
                int minindex = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                        maxindex = i;
                    }
                    else if (min > arr[i])
                    {
                        min = arr[i];
                        minindex = i;
                    }
                }
                arr[maxindex] = min;
                arr[minindex] = max;
                foreach (int arraydakielement in arr)

                {
                    Console.WriteLine(arraydakielement);
                }

            }









            //Console.WriteLine(maxNumber());
            //Console.WriteLine(Replace("hello", 1));
            //Console.WriteLine(Contain("salam", 'a'));
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



            //static StringBuilder Replace(string vord, int index)
            //{
            //    StringBuilder replace = new StringBuilder();
            //    for (int i = 0; i < vord.Length; i++)
            //    {
            //        if (i!=index)
            //        {
            //            replace.Append(vord[i]);
            //        }
            //        else
            //        {
            //            replace.Append(2);
            //        }

            //    }
            //    return replace;
            //}

            //salam  a
            //static bool Contain(string text,char a)
            //{
            //    int count = 0;
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (text[i] == a)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 1)
            //    {
            //        return true;
            //    }
            //    return false;
            //}

            //static int maxNumber()
            //{
            //    int[] arr = { 5, 9, 2, 43, 1, 53, 30 };
            //    int maxNumber = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {

            //        if (maxNumber < arr[i])
            //        {
            //            maxNumber = arr[i];
            //        }

            //    }
            //    return maxNumber;


            //  int userRating ;//number1

            //  int myNumber2 = 50;//number2

            //  var result2 = AddNumber(  out userRating, myNumber2);
            //  Console.WriteLine(result2);


            //  Console.WriteLine(userRating);

            //  }

            //static int AddNumber( out int number1,int number2)
            //{
            //  number1 = 250;
            //  return number1 + number2;
        }
    }






}
