/*
 * Done by:
 * Student Name: David Hrytsenok
 * Student Group: B-121-24-1-SE
 * Lab 2.1 CS
 */

using System;
using FiguresLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square((0, 0), (0, 2), (2, 2), (2, 0));

            Console.WriteLine($"Side length: {square.SideLength}");
            Console.WriteLine($"Perimeter: {square.Perimeter}");
            Console.WriteLine($"Area: {square.Area}");
        }
    }
}