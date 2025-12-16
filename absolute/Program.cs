using System;

class AbsoluteValue
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            number = -number;
        }

        Console.WriteLine("Absolute value: " + number);
    }
}
