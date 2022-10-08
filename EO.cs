using System;

namespace EvenOdd
{
    internal class EO
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number:");
            int a=Convert.ToInt32(Console.ReadLine());

            if(a%2==0)
            {
                Console.WriteLine("Number Is Even");
            }
            else
            {
                Console.WriteLine("Number Is Odd");
            }
        }
    }
}
