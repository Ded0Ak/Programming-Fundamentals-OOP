using System;
using System.Collections.Generic;
using System.Linq;

public class TextContainer
{
    private List<StringClass> strings;

    public TextContainer()
    {
        strings = new List<StringClass>();
    }

    public void AddString(StringClass str)
    {
        strings.Add(str);
    }

    public void RemoveString(StringClass str)
    {
        strings.Remove(str);
    }

    public void ClearText()
    {
        strings.Clear();
    }

    public int CountCharacters()
    {
        return strings.Sum(str => str.Content.Length);
    }

    public int FindString(string searchStr)
    {
        return strings.Count(str => str.Content.Contains(searchStr));
    }

    public void ReplaceCharacterInText(char oldChar, char newChar)
    {
        foreach (var str in strings)
        {
            str.ReplaceCharacter(oldChar, newChar);
        }
    }
}
