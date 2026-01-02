using System;

class NumberType
{
    static int CheckNumber(int number)
    {
        if (number > 0) return 1;
        if (number < 0) return -1;
        return 0;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(CheckNumber(n));
    }
}
