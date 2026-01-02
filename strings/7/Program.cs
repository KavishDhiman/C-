using System;

class ToggleCase
{
    static string Toggle(string s)
    {
        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
                result[i] = char.ToLower(s[i]);
            else
                result[i] = char.ToUpper(s[i]);
        }
        return new string(result);
    }

    static void Main()
    {
        Console.WriteLine(Toggle(Console.ReadLine()));
    }
}
