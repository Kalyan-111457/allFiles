using System;
namespace ConsoleApp2
{
    class DateTim1
    {
        public static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(2002,12,28);

            Console.WriteLine("Day of the week is {0}", awesomeDate.DayOfWeek); //it tells staudray
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            awesomeDate = awesomeDate.AddDays(3);
            Console.WriteLine("The new date is {0}", awesomeDate);  


            TimeSpan timespan = new TimeSpan(12, 29, 32);
            Console.WriteLine("The Time span is {0}", timespan);

            timespan = timespan.Subtract(new TimeSpan(0, 12, 20));

            Console.WriteLine("The new Time Span is {0}", timespan.ToString());





        }
    }
}