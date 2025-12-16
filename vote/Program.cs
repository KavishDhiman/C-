using System;
class vote
{
    static void Main()
    {
        Console.WriteLine("Enter the age:");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("Eligible to vote");
        }
        else
        {
            Console.WriteLine("Not eligible to vote");
        }
    }
}