using System;
using System.Diagnostics;
namespace consoleApp2
{
    class Enumerated
    {

        enum CarColors:byte
        {
            orange =1,
            blue,
            red,
            yellow,
            purple,
            pink
        }
        public static void Main(String[] args)
        {

            CarColors car1 = CarColors.blue;
            Paintcar(car1);

        
        }

         static void Paintcar(CarColors cc)
        {
            Console.WriteLine("The Car was paineted {0} with the code{1}", cc, Convert.ToInt32(cc));
        }
    }
}