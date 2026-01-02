using System;

class SubstringCount
{
    static int CountOccurrences(string str, string sub)
    {
        int count = 0;
        for (int i = 0; i <= str.Length - sub.Length; i++)
            if (str.Substring(i, sub.Length) == sub)
                count++;
        return count;
    }

    static void Main()
    {
        string s = Console.ReadLine();
        string sub = Console.ReadLine();
        Console.WriteLine(CountOccurrences(s, sub));
    }
}
