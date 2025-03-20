/*
 * Done by:
 * Student Name: David Hrytsenok
 * Student Group: B-121-24-1-SE
 * Lab 1.3 CS
 */

using System;
using TriangleLibrary;

class Program
{
    static void Main()
    {
        Triangle T1 = new Triangle();
        Triangle T2 = new Triangle(2, 3, 5, 8, 7, 5);
        Triangle T3 = new Triangle(T2);

        T3 = T3 * 2;
        T1 = T3 + T2;

        Console.WriteLine("Triangle T1: " + T1);
        Console.WriteLine("Triangle T2: " + T2);
        Console.WriteLine("Triangle T3: " + T3);
    }
}