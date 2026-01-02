using System;

class BMI2D
{
    static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double heightM = data[i, 1] / 100;
            data[i, 2] = data[i, 0] / (heightM * heightM);
        }
    }

    static string[] GetStatus(double[,] data)
    {
        string[] status = new string[10];
        for (int i = 0; i < 10; i++)
        {
            double bmi = data[i, 2];
            status[i] = bmi < 18.5 ? "Underweight" :
                        bmi < 25 ? "Normal" :
                        bmi < 30 ? "Overweight" : "Obese";
        }
        return status;
    }

    static void Main()
    {
        double[,] data = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = double.Parse(Console.ReadLine()); // weight
            data[i, 1] = double.Parse(Console.ReadLine()); // height cm
        }

        CalculateBMI(data);
        string[] status = GetStatus(data);

        for (int i = 0; i < 10; i++)
            Console.WriteLine($"{data[i, 0]} {data[i, 1]} {data[i, 2]} {status[i]}");
    }
}
