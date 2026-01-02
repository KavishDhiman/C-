using System;

class NumberChecker1
{
    static int CountDigits(int n) => n.ToString().Length;

    static int[] GetDigits(int n)
    {
        char[] c = n.ToString().ToCharArray();
        int[] d = new int[c.Length];
        for (int i = 0; i < c.Length; i++) d[i] = c[i] - '0';
        return d;
    }

    static bool IsDuck(int[] d)
    {
        foreach (int x in d) if (x != 0) return true;
        return false;
    }

    static bool IsArmstrong(int n, int[] d)
    {
        int power = d.Length;
        int sum = 0;
        foreach (int x in d) sum += (int)Math.Pow(x, power);
        return sum == n;
    }

    static void LargestSmallest(int[] d)
    {
        int max = int.MinValue, min = int.MaxValue;
        int sMax = int.MinValue, sMin = int.MaxValue;

        foreach (int x in d)
        {
            if (x > max) { sMax = max; max = x; }
            else if (x > sMax && x != max) sMax = x;

            if (x < min) { sMin = min; min = x; }
            else if (x < sMin && x != min) sMin = x;
        }

        Console.WriteLine($"{max} {sMax} {min} {sMin}");
    }
}
