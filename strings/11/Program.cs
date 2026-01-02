using System;

class AnagramCheck
{
    static bool IsAnagram(string a, string b)
    {
        if (a.Length != b.Length) return false;

        char[] x = a.ToCharArray();
        char[] y = b.ToCharArray();
        Array.Sort(x);
        Array.Sort(y);

        return new string(x) == new string(y);
    }

    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        Console.WriteLine(IsAnagram(s1, s2) ? "Anagram" : "Not Anagram");
    }
}

