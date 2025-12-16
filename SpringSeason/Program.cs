using System;
class SpringSeason
{
    static void Main()
    {
        Console.WriteLine("Enter the month number (1-12):");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the day:");
        int day = int.Parse(Console.ReadLine());

        if ((month == 3 && day >= 20) ||(month == 4 && day >= 1)|| (month == 5 && day >= 1)||(month == 6 && day <= 20))
        {
            Console.WriteLine("It's Spring Season");
        }
        else
        {
            Console.WriteLine("It's not Spring Season");
        }
    }
}