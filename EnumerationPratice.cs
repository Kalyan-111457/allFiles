using System;
using System.Net;
namespace consoleApp2
{
    class EnumerationPratice
    {

        enum Class1
        {
            sunday,
            monday,
            Tuesdays,
            wednesday,
            Thursday,
            Friday,
            Saturday
        }
        public static void Main(string[] args)
        {
            Class1 obj = Class1.sunday;
            carcolor1(obj);

        }

        static void carcolor1(Class1 days)
        {
            Console.WriteLine("The new Car is :{0}", days);
            int k1 = Convert.ToInt32(days);

            Console.WriteLine("The new Car Code is :{0}", k1);

        }
    }
}