class NumberChecker3
{
    static int[] Reverse(int[] d)
    {
        int[] r = new int[d.Length];
        for (int i = 0; i < d.Length; i++) r[i] = d[d.Length - 1 - i];
        return r;
    }

    static bool AreEqual(int[] a, int[] b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i < a.Length; i++)
            if (a[i] != b[i]) return false;
        return true;
    }

    static bool IsPalindrome(int[] d) => AreEqual(d, Reverse(d));
}
