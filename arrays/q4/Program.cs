using System;

class StoreAndSum
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == 10)
                break;

            numbers[index++] = input;
        }

        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine($"Total = {total}");
    }
}
