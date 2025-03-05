using System;

namespace StringLibrary
{
    public class StringManipulator
    {
        private string _value;

        // Constructors
        public StringManipulator()
        {
            _value = string.Empty;
        }

        public StringManipulator(string value)
        {
            _value = value;
        }

        // Method to get the string value
        public string GetValue()
        {
            return _value;
        }

        // Method to get the length of the string
        public int GetLength()
        {
            return _value.Length;
        }

        // Method to sort the string in descending order
        public string SortDescending()
        {
            char[] chars = _value.ToCharArray();
            Array.Sort(chars);
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}