using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Vehicle
    {
        public string Model;
        public double FuelConsumption;
        public double Capacity;
        public double CurrentFuel;


        public Vehicle(string model,double fuelConsumption, double capacity)
        {
            Model = model;
            FuelConsumption = fuelConsumption;
            Capacity = capacity;
        }

        public void Run(double km, double currentFuel)
        {
            double MaxKm = currentFuel * 100 / FuelConsumption;
            double neededFuel = km / 100 * FuelConsumption;

            if (MaxKm<km)
            {
                double additionalFuel = neededFuel - currentFuel;
                if (additionalFuel+currentFuel>Capacity)
                {
                    Console.WriteLine("Bir bak bes elemir");
                }
                else
                {
                    Console.WriteLine($"{additionalFuel} litr benzin lazimdir");
                }

           
            }
            else
            {
                Console.WriteLine($"Gede biler.Qalan yanacaq:{currentFuel - neededFuel}");
            }


        }
    }
}
