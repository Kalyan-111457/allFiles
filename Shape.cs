using System;                            //abstract  -->circle-->Rectangle
namespace consoleApp2
{
    abstract class Shape
    {
        public string name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a{name}");
        }

        public abstract double Area();
    }
}