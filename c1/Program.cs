using System;

class Divisible
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int num = Console.ReadLine();
        if (num % 5 == 0)
        {
            Console.WriteLine("The number is divisible by 5");
        }
        else
        {
            Console.WriteLine("The number is not divisible by 5");
        }
    }
}