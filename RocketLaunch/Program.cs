using System;
class rocketlaunch
{
    static void Main()
    {
        Console.WriteLine("Enter the countdown start number:");
        int count = int.Parse(Console.ReadLine());
        while (count >= 0)
        {
            Console.WriteLine(count);
            count--;
        }
        Console.WriteLine("Liftoff!");
    }
}