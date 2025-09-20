using System;
namespace consoleApp2 ///animals--->OOps--->ConnectionAnimalandOpps
{
    class Opps
    {
        public static double GetArea(string shape = "", double length1 = 0, double length2 = 0)
        {
            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;


            }
            else if (string.Equals("Traingle", shape, StringComparison.OrdinalIgnoreCase))
            
            {
                return 0.5 * length1 * length2;
            }

            else if (string.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14 * Math.Pow(length1, 2);

            }
            else
            {
                return -1;
            }
        }
    }
}