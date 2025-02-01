/*
* Done by:
* Student Name: David Hrytsenok
* Student Group: B-121-24-1-SE
* Lab 1.1 C#
*/

// filepath: /c:/Users/user/Documents/Programming-Fundamentals-OOP/Labs/Lab 1/С#/StringHandlerApp/Program.cs
using System;

namespace StringHandlerApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine(); // Read user input

            StringHandler handler = new StringHandler(input);

            // Output the results
            Console.WriteLine("Original string: " + handler.GetValue());
            Console.WriteLine("String length: " + handler.GetLength());
            Console.WriteLine("Sorted (descending): " + handler.GetSortedDescending());
        }
    }
}
