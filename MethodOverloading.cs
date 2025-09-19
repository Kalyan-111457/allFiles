using System;
namespace consoleApp2
{
    class MethodOverloading
    {
        public static void Main(string[] args)
        {
            Getsum2(10.0, 20.0);
            Getsum2("20", "30");

        }

        static double Getsum2(double x=1,double y = 1)
        {
            return x * y;
        }
        static double Getsum2(string x = "1", string  y = "1")
        {
            double x1 = Convert.ToDouble(x);
            double y1 = Convert.ToDouble(y);
            return x1 * y1;
        }
    }
}