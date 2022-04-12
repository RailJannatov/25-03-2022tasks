using System;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_RaceCondition
{
    class Program
    {
        #region Race Condition,DeadBlockk
        //public int Count { get; set; }
        //private Object newObg = new Object();
        //private Object newObg1 = new Object();
        //void Increase()
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        lock (newObg)
        //        {
        //            Count++;
        //        }
                 
                

        //    }
        //}
        //void Decrease()
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        lock (newObg)
        //        {
        //            Count--;
        //        }
               

                    
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {

            #region RaceCondition,DeadBlock
            //Program p = new Program();

            //Thread thread2 = new Thread(p.Decrease);
            //Thread thread1 = new Thread(p.Increase);
            //thread2.Start();
            //thread1.Start();
            //thread1.Join();
            //thread2.Join();
            //Console.WriteLine($"Count:{p.Count}");
            #endregion
            #region Thread
            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);
            //thread1.Start();
            //thread2.Start();
            //thread1.Join();
            //Console.WriteLine("Hello");
            #endregion
            #region Async,Await
            //Go();
            #endregion
        

        }

      


        #region Async,await
        //public static void Go()
        //{
        //    GoAsync();
        //    Console.ReadLine();
        //}
        //public static async void GoAsync()
        //{

        //    Console.WriteLine("Starting");

        //    var task1 = Sleep(7000);
        //    var task2 = Sleep(4000);
        //    var task3 = Sleep(5000);

        //    int[] result = await Task.WhenAll(task1, task2, task3);

        //    Console.WriteLine($"Slept for a total of {result[0] + result[1] + result[2]}");

        //}

        //private async static Task<int> Sleep(int ms)
        //{
        //    Console.WriteLine($"Sleeping for {ms} at {Environment.TickCount}");
        //    await Task.Delay(ms);
        //    Console.WriteLine($"Sleeping for {ms} at {Environment.TickCount}");
        //    return ms;
        //}
        //static async Task<int> Sum()
        //{
        //    int result = 0;
        //    var task = Task.Run(() =>
        //    {
        //        for (int i = 0; i < 10000000; i++)
        //        {
        //            result += i;
        //        }
        //    });
        //    await task;

        //    return result;
        //}
        #endregion

        #region Thread
        //static void Loop1()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {

        //        Console.WriteLine($"Loop1:{i}");
        //    }
        //}
        //static void Loop2()
        //{
        //    for (int i = 100; i < 200; i++)
        //    {

        //        Console.WriteLine($"Loop2:{i}");
        //    }
        //}
        #endregion

    }
}
