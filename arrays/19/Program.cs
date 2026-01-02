using System;

class StudentGrades2D
{
    static void Main()
    {
        Console.Write("Enter students: ");
        int n = int.Parse(Console.ReadLine());

        double[,] marks = new double[n, 3];
        double[] percent = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3; j++)
                marks[i, j] = double.Parse(Console.ReadLine());

            percent[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;
            grade[i] = percent[i] >= 60 ? "Pass" : "Fail";
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"{percent[i]} {grade[i]}");
    }
}
