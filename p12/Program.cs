using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter the base");
        double basein =double.Parse(Console.ReadLine());
        
        Console.WriteLine("enter the height");
        double height =double.Parse(Console.ReadLine());

        double area = 0.5*basein*height;

        Console.WriteLine("The area is "+area);
    }
}