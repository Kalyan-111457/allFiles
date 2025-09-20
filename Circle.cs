using consoleApp2;
using System;
namespace ConsoleApp2
{
    class Circle:Shape    
    {
        public double radius { get; set; }

       public  Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return 3.14 * radius * radius;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a Raidus of{radius}");
        }


    }
}