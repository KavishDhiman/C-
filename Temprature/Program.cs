using System;

class TemperatureCheck
{
    static void Main()
    {
        Console.Write("Enter temperature: ");
        int temp = Convert.ToInt32(Console.ReadLine());

        if (temp < 0)
        {
            Console.WriteLine("Freezing");
        }
        else if (temp <= 20)
        {
            Console.WriteLine("Cold");
        }
        else if (temp <= 35)
        {
            Console.WriteLine("Warm");
        }
        else
        {
            Console.WriteLine("Hot");
        }
    }
}
