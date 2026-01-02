using System;

class RemoveDuplicates
{
    static string Remove(string s)
    {
        string result = "";
        foreach (char c in s)
            if (!result.Contains(c))
                result += c;
        return result;
    }

    static void Main()
    {
        Console.WriteLine(Remove(Console.ReadLine()));
    }
}
