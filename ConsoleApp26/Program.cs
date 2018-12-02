using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Program
    {
        static void Main(string[] args)
        {
            Motor motorV4 = new Motor() { Size = 2.4, Capacity = 140 };
            Motor motorV6 = new Motor() { Size = 3.2, Capacity = 180 };
            Motor motorV8 = new Motor() { Size = 4.2, Capacity = 260 };
            Motor motorV12Diesel = new Motor { Size = 5.0, Capacity = 300 };

            Random randomValue = new Random();
            Car BMW = new Car() { Brand = Brand.BMW, Color = Color.red, Price = 12000, Motor = motorV4 };
            Car Audi = new Car() { Brand = Brand.Audi, Price = 20000, Color = Color.blue, Motor = motorV6 };
            Car Honda = new Car() { Brand = Brand.Honda, Price = 25000, Color = Color.white, Motor = motorV8 };
            Truck Marmon = new Truck() { Brand = Brand.Marmon, Price = 60000, Color = Color.red, Motor = motorV12Diesel, Tonnage = 25 };

            BMW.AboutACar();
            Audi.AboutACar();
            Honda.AboutACar();
            Marmon.AboutACar();

            Console.ReadLine();
        }
    }
}
