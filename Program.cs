using System;

<<<<<<< HEAD
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
=======
class Program
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle = " + area);
    }
}
>>>>>>> cb473cfebc51eba2d4f21101cad863b6c7433a9c
