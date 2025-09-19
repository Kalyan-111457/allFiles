using System;
namespace consoleApp2
{
    class ExceptionHandling
    {
        public static void Main(String[] args)
        {
            double num1 = 5;

            double num2 = 0;

            try
            {
                Console.WriteLine("5/0=:{0}", DoDivision(num1,num2));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning Up");
            }
        }
         static double DoDivision(double n1,double n2)
        {
            if (n2 == 0)
            {
                throw new System.DivideByZeroException("Denomibator cannot be Zero");
            }
            return n1 / n2;
        }
    }

}