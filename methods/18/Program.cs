using System;

class FriendsInfo
{
    static int FindYoungest(int[] age)
    {
        int min = 0;
        for (int i = 1; i < age.Length; i++)
            if (age[i] < age[min]) min = i;
        return min;
    }

    static int FindTallest(double[] height)
    {
        int max = 0;
        for (int i = 1; i < height.Length; i++)
            if (height[i] > height[max]) max = i;
        return max;
    }

    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] age = new int[3];
        double[] height = new double[3];

        for (int i = 0; i < 3; i++)
        {
            age[i] = int.Parse(Console.ReadLine());
            height[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Youngest: " + names[FindYoungest(age)]);
        Console.WriteLine("Tallest: " + names[FindTallest(height)]);
    }
}
