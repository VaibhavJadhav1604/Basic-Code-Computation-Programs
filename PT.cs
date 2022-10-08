using System;

namespace PowerOfTwo
{
    internal class PT
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number Till Power Is Required:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num <= 31)
            {
                for (int i = 1; i <= num; i++)
                {
                    double result = Math.Pow(i, 2);
                    Console.WriteLine("Power Of Number:"+ i +" Is:"+ result);

                }
            }
        }
    }
}
