public class StringClass : ICharacterReplacer
{
    private string content;

    public StringClass(string content)
    {
        this.content = content;
    }

    public string Content => content;

    public void ReplaceCharacter(char oldChar, char newChar)
    {
        content = content.Replace(oldChar, newChar);
    }
}
