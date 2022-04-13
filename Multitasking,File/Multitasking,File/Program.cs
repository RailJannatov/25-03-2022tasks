using Multitasking_File.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Multitasking_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetHttpContent();
            //GetHttpContentAsync();
            //Console.ReadLine();

            #region File,StreamReader,StreamWriter
            //Directory.CreateDirectory(@"C:\Users\Rail\Desktop/Bp540");
            //Directory.CreateDirectory(@"C:\Users\Rail\Desktop/Bp540/HighStudents");
            //File.Create(@"C:\Users\Rail\Desktop/Bp540/ibrahim.txt");
            //File.Create(@"C:\Users\Rail\Desktop/Bp540/HighStudents/murad.txt");
            //File.Create(@"C:\Users\Rail\Desktop/Bp540/ibrahim2.txt");
            //File.Create(@"C:\Users\Rail\Desktop/Bp540/samir.txt");
            //File.Create(@"C:\Users\Rail\Desktop/Bp540/ibrahim2.txt");
            //Directory.CreateDirectory(@"C:\Users\Rail\Desktop/P318/Students");
            //Directory.Delete(@"C:\Users\Rail\Desktop/P318");
            //if(!Directory.Exists(@"C:\Users\Rail\Desktop/P318"))
            //{
            //    Directory.CreateDirectory(@"C:\Users\Rail\Desktop/Q240");
            //}
            //Directory.CreateDirectory(@"C:\Users\Rail\Desktop/Q240");
            //File.Create(@"C:\Users\Rail\Desktop/Q240/test.txt");

            //StreamWriter streamWriter = new StreamWriter(@"C:\Users\Rail\Desktop/Q240/test.txt");
            //streamWriter.WriteLine("Bmw");
            //streamWriter.Close();

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Rail\Desktop/Q240/test.txt"))
            {
                streamWriter.WriteLine("Tesla");

            }

            //StreamReader streamReader = new StreamReader(@"C:\Users\Rail\Desktop/Q240/test.txt");
            //var res = streamReader.ReadToEnd();

            #endregion

            #region Json,Serialize
            //Product p1 = new Product { Id = 1, Name = "Apple", Price = 2500 };
            //Product p2 = new Product { Id = 2, Name = "Samsung", Price = 1500 };

            //OrderItem orderItem1 = new OrderItem()
            //{
            //    Id = 1,
            //    Count = 2,
            //    product = p1,
            //    TotalPrice = p1.Price * 2
            //};
            //OrderItem orderItem2 = new OrderItem()
            //{
            //    Id = 2,
            //    Count = 2,
            //    product = p2,
            //    TotalPrice = p2.Price * 2
            //};
            //List<OrderItem> orders = new List<OrderItem>();

            //orders.Add(orderItem1);
            //orders.Add(orderItem2);
            //Order order = new Order { Id = 1, items = orders };

            //var json = JsonConvert.SerializeObject(order);


            //using (StreamWriter streamWriter1 = new StreamWriter(@"C:\Users\Rail\Desktop\Multitasking,File\Multitasking,File\Files\json1.json"))
            //{
            //    streamWriter1.Write(json);
            //}

            string result;


            using (StreamReader streamReader = new StreamReader(@"C:\Users\Rail\Desktop\Multitasking,File\Multitasking,File\Files\json1.json"))
            {
                 result = streamReader.ReadToEnd();
            }
            var parseJson = JsonConvert.DeserializeObject<Order>(result);
            Console.WriteLine(parseJson.items[1].product.Price);

            #endregion






        }
        #region MultiTasking
        //public async static Task GetHttpContentAsync()
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    var tasks = new List<Task<string>>();
        //    foreach (var item in GetUrls())
        //    {
        //        var client = new HttpClient();
        //        tasks.Add(client.GetStringAsync(item));
        //        //Console.WriteLine(item + "-->" + result.Length);
        //    }
        //    await Task.WhenAll(tasks);
        //    foreach (var item in tasks)
        //    {
        //        Console.WriteLine(item.Result.Length);
        //    }
        //    stopwatch.Stop();
        //    Console.WriteLine("Multitasking-->" + stopwatch.ElapsedMilliseconds);
        //}
        //public static void GetHttpContent()
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    foreach (var item in GetUrls())
        //    {
        //        var client = new HttpClient();
        //        string result = client.GetStringAsync(item).Result;
        //        Console.WriteLine(item+ "-->"+result.Length);
        //    }
        //    stopwatch.Stop();
        //    Console.WriteLine("ardiciliq-->" + stopwatch.ElapsedMilliseconds);
        //}
        //public static string[] GetUrls()
        //{
        //    return new string[]
        //    {
        //        "https://docs.microsoft.com",
        //        "https://docs.microsoft.com/aspnet/core",
        //        "https://docs.microsoft.com/azure",
        //        "https://docs.microsoft.com/azure/devops",
        //        "https://docs.microsoft.com/dotnet",
        //        "https://docs.microsoft.com/dynamics365",
        //        "https://docs.microsoft.com/education",
        //        "https://docs.microsoft.com/enterprise-mobility-security",
        //        "https://docs.microsoft.com/gaming",
        //        "https://docs.microsoft.com/graph",
        //        "https://docs.microsoft.com/microsoft-365",
        //        "https://docs.microsoft.com/office",
        //        "https://docs.microsoft.com/powershell"
        //    };
        //}
        #endregion
    }
}
