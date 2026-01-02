using System;

class SimpleInterest
{
    static double CalculateSI(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    static void Main()
    {
        Console.Write("Enter Principal: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double r = double.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        double t = double.Parse(Console.ReadLine());

        double si = CalculateSI(p, r, t);

        Console.WriteLine($"The Simple Interest is {si} for Principal {p}, Rate of Interest {r} and Time {t}");
    }
}
