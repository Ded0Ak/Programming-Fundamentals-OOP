using System;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings str1 = new Symbols("Hell* W*rld");
            Strings str2 = new UppercaseLetters("BeautifulBBb");

            Console.WriteLine($"Length of str1: {str1.GetLength()}");
            Console.WriteLine($"Count of '*' in str1: {str1.CountSymbol('*')}");
            Console.WriteLine($"Length of str2: {str2.GetLength()}");
            Console.WriteLine($"Count of 'B' in str2: {str2.CountSymbol('B')}");
        }
    }
}
