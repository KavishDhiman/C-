using System;
class Program
{
    static void Main()
    {
        int pens = 14;
        int students = 3;
        int equalpen=pens/students;
        int remainder=pens%students;
        Console.WriteLine("The Pen Per Student is"+equalpen+" and the remaining pen not distributed is"+remainder);
    }
}