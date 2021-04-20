using System;

public class Kata
{
    public static string Remove_char(string s)
    {
        string character = s.Remove(s.Length - 1, 1);
        character = character.Remove(0, 1);
        return character;
    }
}
