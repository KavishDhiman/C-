using System;

class CheckNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string result = number >= 0 ? "Positive" : "Negative";
        Console.WriteLine("The number is " + result);
    }
}
