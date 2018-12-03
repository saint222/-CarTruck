using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Truck : Car 
    {
        public double Tonnage { get; set; }

        public override void AboutACar()
        {
            Console.WriteLine($"This is a {Color} {Brand} with a {Motor.Name} of {Motor.Size} size and {Motor.Capacity} motor capacity and it's price is {Price}$. It's tonnage is {Tonnage} t.;");
        }
    }
}
