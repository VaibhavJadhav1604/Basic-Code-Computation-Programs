using System;

namespace LeapYear
{
    internal class LP
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter Any Year:");
            year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine(year + ":Is A Leap Year");
            }
            else
            {
                Console.WriteLine(year + ":Is Not A Leap Year");
            }
        }
    }
}
