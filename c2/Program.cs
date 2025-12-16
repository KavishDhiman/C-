using System;

class findingLargest
{
    static void Main()
    {
        Console.WriteLine("Enter the 3 numbers:");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        if (n1 > n2 && n1 > n3)
        {
            Console.WriteLine("First is the largest number");
        }
        else if (n2 > n1 && n2 > n3)
        {
            Console.WriteLine("Second is the largest number");
        }
        else
        {
            Console.WriteLine("Third is the largest");
        }
    }
}
