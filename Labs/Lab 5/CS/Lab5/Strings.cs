using System;

namespace PolymorphismDemo
{
    public class Strings
    {
        protected string value;

        public Strings(string value)
        {
            this.value = value;
        }

        public virtual int GetLength()
        {
            return value.Length;
        }

        public virtual int CountSymbol(char symbol)
        {
            int count = 0;
            foreach (var ch in value)
            {
                if (ch == symbol)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
