using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Add: " + calc.Add(10, 5));
            Console.WriteLine("Subtract: " + calc.Subtract(10, 5));
        }
    }
}
