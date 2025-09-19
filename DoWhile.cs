using System;
namespace consoleApp2
{
    class DoWhile
    {
        public static void Main(String[] args)
        {
            Random rand = new Random();
            int secret = rand.Next(1, 11);
            do
            {
                Console.WriteLine("Enter A number between 1 to 10");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == secret)
                {
                    Console.WriteLine($"You Guessed No is Mathced with{guess}");

                    break;
                }
                else
                {
                    Console.WriteLine("Better Luck Next Time");
                }

            } while (true);

        }
    }
}