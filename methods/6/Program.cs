using System;

class SpringSeason
{
    static bool IsSpring(int month, int day)
    {
        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
            return true;

        return false;
    }

    static void Main(string[] args)
    {
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        Console.WriteLine(IsSpring(month, day) ? "Its a Spring Season" : "Not a Spring Season");
    }
}
