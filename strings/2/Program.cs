using System;

class ReverseString
{
    static string Reverse(string s)
    {
        string rev = "";
        for (int i = s.Length - 1; i >= 0; i--)
            rev += s[i];
        return rev;
    }

    static void Main()
    {
        Console.WriteLine(Reverse(Console.ReadLine()));
    }
}
