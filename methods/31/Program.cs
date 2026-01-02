using System;

class ZaraBonus
{
    // Method to generate salary and years of service
    static double[,] GenerateEmployeeData()
    {
        Random rand = new Random();
        double[,] data = new double[10, 2]; // [salary, years]

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = rand.Next(10000, 99999); // 5-digit salary
            data[i, 1] = rand.Next(1, 11);        // years of service
        }
        return data;
    }

    // Method to calculate new salary and bonus
    static double[,] CalculateBonus(double[,] data)
    {
        double[,] result = new double[10, 2]; // [newSalary, bonus]

        for (int i = 0; i < 10; i++)
        {
            double salary = data[i, 0];
            double years = data[i, 1];
            double bonus = years > 5 ? salary * 0.05 : salary * 0.02;

            result[i, 0] = salary + bonus;
            result[i, 1] = bonus;
        }
        return result;
    }

    // Method to calculate totals and display
    static void DisplayResult(double[,] oldData, double[,] newData)
    {
        double totalOld = 0, totalNew = 0, totalBonus = 0;

        Console.WriteLine("Salary\tYears\tBonus\tNew Salary");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
                $"{oldData[i, 0]}\t{oldData[i, 1]}\t{newData[i, 1]}\t{newData[i, 0]}"
            );

            totalOld += oldData[i, 0];
            totalNew += newData[i, 0];
            totalBonus += newData[i, 1];
        }

        Console.WriteLine("\nTotal Old Salary: " + totalOld);
        Console.WriteLine("Total New Salary: " + totalNew);
        Console.WriteLine("Total Bonus Paid: " + totalBonus);
    }

    static void Main()
    {
        double[,] employeeData = GenerateEmployeeData();
        double[,] bonusData = CalculateBonus(employeeData);
        DisplayResult(employeeData, bonusData);
    }
}
