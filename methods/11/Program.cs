using System;

class FactorsProgram
{
    static int[] FindFactors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) count++;

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= n; i++)
            if (n % i == 0) factors[index++] = i;

        return factors;
    }

    static int Sum(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr) sum += x;
        return sum;
    }

    static int Product(int[] arr)
    {
        int product = 1;
        foreach (int x in arr) product *= x;
        return product;
    }

    static double SumOfSquares(int[] arr)
    {
        double sum = 0;
        foreach (int x in arr) sum += Math.Pow(x, 2);
        return sum;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(n);

        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine("Sum of Factors: " + Sum(factors));
        Console.WriteLine("Product of Factors: " + Product(factors));
        Console.WriteLine("Sum of Squares of Factors: " + SumOfSquares(factors));
    }
}    