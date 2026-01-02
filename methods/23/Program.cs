class NumberChecker2
{
    static int SumDigits(int[] d)
    {
        int s = 0; foreach (int x in d) s += x; return s;
    }

    static double SumSquares(int[] d)
    {
        double s = 0; foreach (int x in d) s += Math.Pow(x, 2); return s;
    }

    static bool IsHarshad(int n, int[] d) => n % SumDigits(d) == 0;

    static int[,] Frequency(int[] d)
    {
        int[,] f = new int[10, 2];
        for (int i = 0; i < 10; i++) f[i, 0] = i;
        foreach (int x in d) f[x, 1]++;
        return f;
    }
}
