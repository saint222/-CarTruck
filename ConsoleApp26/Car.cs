using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Car
    {

        public Brand Brand { get; set; }
        public Color Color { get; set; }
        public int Price { get; set; }
        public Motor Motor { get; set; }

        public Car()
        {

        }
        public Car(Brand brand, Color color, Motor motor, int price)

        {
            Brand = brand;
            Color = color;
            Motor = motor;
            Price = price;
        }

        public virtual void AboutACar()
        {
            Console.WriteLine($"This is a {Color} {Brand} with a {Motor.Name} of {Motor.Size} size and {Motor.Capacity} motor capacity and it's price is {Price}$;");
        }

    }
}
