using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter the perimeter of  the square");
        double perimeter = double.Parse(Console.ReadLine());

        double side = perimeter/4;
        Console.WriteLine("The side of square is "+side);
    }
}

