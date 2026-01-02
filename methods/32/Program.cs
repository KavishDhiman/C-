using System;

class StudentScorecard
{
    // Generate random PCM scores
    static double[,] GenerateScores(int students)
    {
        Random rand = new Random();
        double[,] scores = new double[students, 3];

        for (int i = 0; i < students; i++)
        {
            scores[i, 0] = rand.Next(35, 100); // Physics
            scores[i, 1] = rand.Next(35, 100); // Chemistry
            scores[i, 2] = rand.Next(35, 100); // Maths
        }
        return scores;
    }

    // Calculate total, average, percentage
    static double[,] CalculateResults(double[,] scores)
    {
        int n = scores.GetLength(0);
        double[,] result = new double[n, 3]; // total, average, percentage

        for (int i = 0; i < n; i++)
        {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double avg = total / 3;
            double percent = (total / 300) * 100;

            result[i, 0] = Math.Round(total, 2);
            result[i, 1] = Math.Round(avg, 2);
            result[i, 2] = Math.Round(percent, 2);
        }
        return result;
    }

    // Display scorecard
    static void DisplayScorecard(double[,] scores, double[,] results)
    {
        Console.WriteLine("Phy\tChem\tMath\tTotal\tAvg\tPercent");
        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.WriteLine(
                $"{scores[i, 0]}\t{scores[i, 1]}\t{scores[i, 2]}\t" +
                $"{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}"
            );
        }
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        double[,] scores = GenerateScores(n);
        double[,] results = CalculateResults(scores);
        DisplayScorecard(scores, results);
    }
}
