using System;

namespace QuotientAndRemainder
{
    internal class QR
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Divident:");
            int divident=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Divisor:");
            int divisor=Convert.ToInt32(Console.ReadLine());

            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine("Quotient :" + quotient);
            Console.WriteLine("Remainder :" + remainder);
        }
    }
}
