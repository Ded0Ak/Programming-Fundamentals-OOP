// filepath: /c:/Users/user/Documents/Programming-Fundamentals-OOP/Labs/Lab 1/С#/StringHandlerApp/StringHandler.cs
using System;
using System.Linq;

namespace StringHandlerApp
{
    public class StringHandler
    {
        private string data; // Stores the string data

        public StringHandler(string str)
        {
            data = str; // Initialize string
        }

        public int GetLength()
        {
            return data.Length; // Returns the length of the string
        }

        public string GetSortedDescending()
        {
            return new string(data.OrderByDescending(c => c).ToArray()); // Sort characters in descending order
        }

        public string GetValue()
        {
            return data; // Returns the original string
        }
    }
}