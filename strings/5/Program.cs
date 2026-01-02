using System;

class LongestWord
{
    static string FindLongest(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longest = words[0];

        foreach (string w in words)
            if (w.Length > longest.Length)
                longest = w;

        return longest;
    }

    static void Main()
    {
        Console.WriteLine(FindLongest(Console.ReadLine()));
    }
}
