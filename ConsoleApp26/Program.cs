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
            Motor motorV4 = new Motor() { Name = Name.motorV4, Size = 2.4, Capacity = 140 };
            Motor motorV6 = new Motor() { Name = Name.motorV6, Size = 3.2, Capacity = 180 };
            Motor motorV8 = new Motor() { Name = Name.motorV8, Size = 4.2, Capacity = 260 };
            Motor motorV12Diesel = new Motor { Name = Name.HDImotor, Size = 5.0, Capacity = 300 };

            Random randomValue = new Random();

            Car BMW = new Car() { Brand = Brand.BMW, Color = Color.red, Price = 25000, Motor = motorV4 };
            Car Audi = new Car() { Brand = Brand.Audi, Color = Color.blue, Price = 20000, Motor = new Motor() { Name = Name.motorV6, Size = 3.2, Capacity = 180 } };
            Car Honda = new Car() { Brand = Brand.Honda, Price = 25000, Color = Color.white, Motor = motorV8 };            
            Car Mazda = new Car(Brand.Mazda, Color.white, motorV6, randomValue.Next(10000,25000));
            Truck Marmon = new Truck() { Brand = Brand.Marmon, Price = 60000, Color = Color.red, Motor = motorV12Diesel, Tonnage = 25 };

            BMW.AboutACar();
            Audi.AboutACar();
            Honda.AboutACar();
            Marmon.AboutACar();
            Mazda.AboutACar();

            Console.ReadLine();
        }
    }
}
