using System;

class QuotientRemainder
{
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number / divisor, number % divisor };
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int divisor = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine($"Quotient: {result[0]}, Remainder: {result[1]}");
    }
}
