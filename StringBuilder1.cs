using System;
using System.Globalization;
using System.Text;   // Needed for StringBuilder

namespace ConsoleApp2
{
    class StringBuilder1
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More Stuff That is Very Important");

           Console.WriteLine("The STringsBuilders are {0}:\n and the second is {1}",sb1,sb2);

            Console.WriteLine("I am converting to String :{0}", sb1.ToString());

            //length of stringBuilder

            Console.WriteLine("The Length of stringBuilder1 is {0}", sb1.Length);

            //append the new Line

            sb2.AppendLine("\n the more important Text");

            Console.WriteLine("After Inserting The new Line is:{0}", sb2);

            //for us culture symbols 

            CultureInfo enus = CultureInfo.CreateSpecificCulture("en-Us");

            double price = 12345.67;

            sb2.AppendFormat(enus, "\n Price: {0:C}", price);


            Console.WriteLine(sb2.ToString());


            //Replace 
            string p = sb2.Replace("must", "kalyan").ToString();
            Console.WriteLine("After Replacing The String is :{0}", p);

            //clear the stringBuilder

            sb2.Clear();

            Console.WriteLine("After Clearning The StringBuilder {0}", sb2.ToString());


            //append and equals

            StringBuilder str3 = new StringBuilder("hello");
            StringBuilder str4 = new StringBuilder("hello");
            if (str3.Equals(str4))
            {
                Console.WriteLine("Both Are Eqaul");
            }
            else
            {
                Console.WriteLine("Both Are Not Eqaual");
            }


            //insert at specified position

            str3.Insert(4, "The new Data is Added to the Existing String");

            Console.WriteLine("After Insrting The Data The String look Likes {0}", str3.ToString());

            //Remove The Specified Data

            str3.Remove(11, 20);

            Console.WriteLine("After Removing The Data is{0}", str3.ToString());


             

        }
    }
}
