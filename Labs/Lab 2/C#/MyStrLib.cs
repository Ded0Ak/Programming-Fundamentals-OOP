using System;
namespace StringLibrary
{
    
    public class StringManipulator
    {
        private string _value;


        public StringManipulator()
        {
            _value = string.Empty;
        }
        public StringManipulator(string value)
        {
            _value = value;а
        }

        public string GetValue()
        {
            return _value;
        }

        public int GetLength()
        {
            return _value.Length;
        }

        public string SortDescending()
        {
            char[] chars = _value.ToCharArray();
            Array.Sort(chars);
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}