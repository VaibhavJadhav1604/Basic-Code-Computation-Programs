using System;

namespace SwapTwoNumbers
{
    internal class STN
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c=0;
            Console.WriteLine("Before Swaping Values Are A:"+ a +" B:"+ b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After Swaping Values Are A:" + a + " B:" + b);
        }
    }
}
