using System;

class DivisibilityCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if ((number % 3 == 0 || number % 5 == 0) &&
            !(number % 3 == 0 && number % 5 == 0))
        {
            Console.WriteLine("Divisible by 3 or 5 but not both");
        }
        else
        {
            Console.WriteLine("Condition not satisfied");
        }
    }
}
