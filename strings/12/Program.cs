using System;

class ReplaceString
{
    static string Replace(string s, char oldChar, char newChar)
    {
        char[] arr = s.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == oldChar)
                arr[i] = newChar;
        return new string(arr);
    }

    static void Main()
    {
        string s = Console.ReadLine();
        char oldChar = Console.ReadLine()[0];
        char newChar = Console.ReadLine()[0];

        Console.WriteLine(Replace(s, oldChar, newChar));
    }
}
