using System;

class PalindromeCheck
{
    static bool IsPalindrome(string s)
    {
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            if (s[i] != s[j]) return false;
            i++; j--;
        }
        return true;
    }

    static void Main()
    {
        string str = Console.ReadLine();
        Console.WriteLine(IsPalindrome(str) ? "Palindrome" : "Not Palindrome");
    }
}
