namespace PolymorphismDemo
{
    public class Symbols : Strings
    {
        public Symbols(string value) : base(value)
        {
        }

        public override int CountSymbol(char symbol)
        {
            return base.CountSymbol('*');
        }
    }
}
