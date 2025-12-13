using System;

class Celcuis
{
    static void Main()
    {
        Console.WriteLine("Enter the temperature in celcuis:");
        float celcius = float.Parse(Console.ReadLine());    
        float faren = (celcius * 9/5) + 32;
        Console.WriteLine("The temperature in Farenhiet is :"+faren);
    }
    

}