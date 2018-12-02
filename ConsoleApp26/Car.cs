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


        public void AboutACar ()
        {
            Console.WriteLine($"This is a {Color} {Brand} with a reliable motor capacity {Motor.Capacity}, motor size {Motor.Size} and it's price is {Price} $ ." ); 
            
        }

    }
}
