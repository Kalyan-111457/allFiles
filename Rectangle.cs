using consoleApp2;
using System;
using System.Reflection.Metadata.Ecma335;
namespace ConsoleApp2
{
    class Rectangle:Shape
    {
        public double length { get; set; }

        public double width { get; set; }

        public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double Area()
        {
            return length * width;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"This is Rectangle {length} and {width}");
        }



    }
}