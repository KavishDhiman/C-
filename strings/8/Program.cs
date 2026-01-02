using System;

class MostFrequentChar
{
    static char FindMostFrequent(string s)
    {
        int max = 0;
        char result = s[0];

        foreach (char c in s)
        {
            int count = 0;
            foreach (char x in s)
                if (x == c) count++;

            if (count > max)
            {
                max = count;
                result = c;
            }
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine(FindMostFrequent(Console.ReadLine()));
    }
}
