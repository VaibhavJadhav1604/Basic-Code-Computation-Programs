using System;

namespace VowelConsonant
{
    internal class VC
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + ":Is Vowel");
            }
            else
            {
                Console.WriteLine(ch + ":Is Consonant");
            }
        }
    }
}
