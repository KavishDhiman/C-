using System;

class StudentGrades
{
    static void Main()
    {
        Console.Write("Enter students: ");
        int n = int.Parse(Console.ReadLine());

        double[] percent = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Physics: ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Maths: ");
            double m = double.Parse(Console.ReadLine());

            percent[i] = (p + c + m) / 3;

            grade[i] = percent[i] >= 75 ? "A" :
                       percent[i] >= 60 ? "B" :
                       percent[i] >= 50 ? "C" : "Fail";
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"{percent[i]}% Grade {grade[i]}");
    }
}
