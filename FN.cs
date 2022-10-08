using System;

namespace FactorsOfNumber
{
    internal class FN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int factor;
            Console.Write("Factors Are:");
            for (factor = 1; factor <= num; factor++)
            {
                if (num % factor == 0)
                {
                    Console.Write(factor +",");
                }
            }
        }
    }
}
