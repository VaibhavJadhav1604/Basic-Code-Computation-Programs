using System;

namespace FlipCoin
{
    internal class FC
    {
        static int headCount = 0;
        static int tailcount = 0;

        static double headpercentage = 0;
        static double tailpercentage = 0;
        static void Main(string[] args)
        {
            Console.Write("Enter The Number Of Flips:");
            int flips = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < flips; i++)
            {

                Random random = new Random();
                int num = random.Next(0,2);
                Console.WriteLine("Random Number Is:" + num);
                if (num == 0)
                {
                    Console.WriteLine("Tails");
                    tailcount++;
                }
                else if (num == 1)
                {
                    Console.WriteLine("Head");
                    headCount++;
                }
            }
            headpercentage = (headCount * 100) / flips;
            tailpercentage = (tailcount * 100) / flips;

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Head Percentage Is:" + headpercentage +"%");
            Console.WriteLine("Tail Percentage Is:" + tailpercentage +"%");
        }
    }
}
