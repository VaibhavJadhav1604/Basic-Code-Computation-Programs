using System;

namespace MaxOfThree
{
    internal class MT
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("1st Number Is Greater");
                }
                else
                {
                    Console.WriteLine("3rd Number Is Greater");
                }
            }
            else if (b > c)
            {
                Console.WriteLine("2nd Number Is Greater");
            }
            else
            {
                Console.WriteLine("3rd Number Is Greater");
            }
        }
    }
}
