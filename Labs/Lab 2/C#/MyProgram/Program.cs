/*
 * Done by:
 * Student Name: David Hrytsenok
 * Student Group: B-121-24-1-SE
 * Lab 1.2 CS
 */

using System;
using StringLibrary;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringManipulator str = new StringManipulator(input);

        Console.WriteLine($"Original string: {str.GetValue()}");
        Console.WriteLine($"String length: {str.GetLength()}");
        Console.WriteLine($"String sorted in descending order: {str.SortDescending()}");
    }
}