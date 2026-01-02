using System;

class NaturalSum
{
    static int RecursiveSum(int n)
    {
        if (n == 0) return 0;
        return n + RecursiveSum(n - 1);
    }

    static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) return;

        int rSum = RecursiveSum(n);
        int fSum = FormulaSum(n);

        Console.WriteLine($"Recursive Sum = {rSum}");
        Console.WriteLine($"Formula Sum = {fSum}");
    }
}
