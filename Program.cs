using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        var rev = Reverse(word);
        return String.Equals(word.ToLower(), rev.ToLower());
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}