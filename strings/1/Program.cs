using System;

class CountVowelsConsonants
{
    static void Count(string input)
    {
        int vowels = 0, consonants = 0;
        input = input.ToLower();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".IndexOf(c) != -1)
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine($"Vowels: {vowels}");
        Console.WriteLine($"Consonants: {consonants}");
    }

    static void Main()
    {
        string str = Console.ReadLine();
        Count(str);
    }
}
