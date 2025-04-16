namespace PolymorphismDemo
{
    public class UppercaseLetters : Strings
    {
        public UppercaseLetters(string value) : base(value)
        {
        }

        public override int CountSymbol(char symbol)
        {
            return base.CountSymbol('B');
        }
    }
}
