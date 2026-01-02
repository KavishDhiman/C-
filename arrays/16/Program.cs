using System;

class BMI
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());

        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Weight (kg): ");
            weight[i] = double.Parse(Console.ReadLine());

            Console.Write("Height (m): ");
            height[i] = double.Parse(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            status[i] = bmi[i] < 18.5 ? "Underweight" :
                        bmi[i] < 25 ? "Normal" :
                        bmi[i] < 30 ? "Overweight" : "Obese";
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"{height[i]} {weight[i]} {bmi[i]} {status[i]}");
    }
}
