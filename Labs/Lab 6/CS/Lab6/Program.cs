class Program
{
    static void Main()
    {
        var textContainer = new TextContainer();
        var str1 = new StringClass("Hello, world!");
        var str2 = new StringClass("C# is cool.");

        textContainer.AddString(str1);
        textContainer.AddString(str2);

        Console.WriteLine("Total characters: " + textContainer.CountCharacters());
        Console.WriteLine("Find 'C#': " + textContainer.FindString("C#"));

        textContainer.ReplaceCharacterInText('o', '0');

        Console.WriteLine("Updated text: " + str1.Content + " " + str2.Content);
    }
}
