using System;
using System.ComponentModel.Design;
namespace ConsoleApp2
{
    class Functions
    {
        public static void Main(string[] args)
        {
            double x = 5;
            double y = 4;
            Console.WriteLine(GetSum(x, y)); //call by value
            Console.WriteLine(x);  //call by value Example



            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15*2={0}", solution); //another method to get the value form the function
            sayhello();

            //callbyReference

            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before Swapping num1:{0} and num2 is{1}", num1, num2);

            swap(ref num1, ref num2);

            Console.WriteLine("After Swapping num1:{0} and num2 is {1}", num1, num2);

            //passing unkown no of parameters


            double overall=GetSumMore(1, 2, 3, 4, 5, 5, 6);
            Console.WriteLine("The Sum is {0}", overall);

            //based on the name of parameters giving the values

            PrintInfo(name: "kishore", zipcode: 522124);

          


        }

        private static void sayhello()
        {
            string name = "";
            Console.WriteLine("What is Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        static double GetSum(double x=1,double y = 1)
        {
            double temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("This X is in Function ", x);
            return x + y;
        }

        static void DoubleIt(int x,out int solution)
        {
            solution = x * 2;
        }

        public static void swap(ref int num1,ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public  static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            return sum;
        }

        public static void PrintInfo(string name,int zipcode)
        {
            Console.WriteLine("{0} Lives in the Zip Code {1}", name, zipcode);
        }
    }
}

//Access Specifiers

//public :Can be Accessed From Another Class
//private:Can't be  Accesed from another Class
//protected:ca'n be accesed by class and derived class