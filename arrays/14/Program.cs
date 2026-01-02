using System;

class DynamicDigits
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int max = 10, index = 0;
        int[] digits = new int[max];

        while (number != 0)
        {
            if (index == max)
            {
                max += 10;
                int[] temp = new int[max];
                digits.CopyTo(temp, 0);
                digits = temp;
            }

            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = 0, secondLargest = 0;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
                secondLargest = digits[i];
        }

        Console.WriteLine($"Largest: {largest}");
        Console.WriteLine($"Second Largest: {secondLargest}");
    }
}
