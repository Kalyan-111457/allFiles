using ConsoleApp2;
using System;
namespace consoleApp2
{
    class Abstract1
    {
        public static void Main(String[] args)
        {
            Circle k1 = new Circle(3.13);
            k1.GetInfo();
            k1.Area();

            Rectangle k2 = new Rectangle(20, 21);
            k2.GetInfo();
            k2.Area();
        }
    }
}