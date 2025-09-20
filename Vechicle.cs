using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Vechicle : IDrivable
    {
        public string Brand { get; set; }
        public int wheels { get; set; }

        public double speed { get; set; }

        public Vechicle(string brand="No Brand",int wheels=0,double speed=0)
        {
            this.Brand = brand;
            this.wheels = wheels;
            this.speed = speed;

        }  
      

        public void Move()
        {
            Console.WriteLine($"The {Brand} moves Forward {speed} Mph");
        }


        public void stop()
        {
            Console.WriteLine($"The {Brand} Stops");
        }
    }
}
