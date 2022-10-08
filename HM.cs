using System;

namespace HarmonicNumber
{
    internal class HM
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Value:");
            int num = (Convert.ToInt32(Console.ReadLine()));

            float hm = 1;
            for(int i = 2; i <= num; i++)
            {
                hm+=(float)1/i;
            }
            Console.WriteLine("Sum Is:"+ hm);
        }
    }
}
