using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number, count = 0;
        while (temp != 0) { count++; temp /= 10; }

        int[] digits = new int[count];
        int index = 0;

        while (number != 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        Console.Write("Reversed: ");
        for (int i = 0; i < count; i++)
            Console.Write(digits[i]);
    }
}
