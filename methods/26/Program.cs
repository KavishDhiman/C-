class NumberChecker5
{
    static int[] Factors(int n)
    {
        int c = 0;
        for (int i = 1; i <= n; i++) if (n % i == 0) c++;
        int[] f = new int[c];
        int idx = 0;
        for (int i = 1; i <= n; i++) if (n % i == 0) f[idx++] = i;
        return f;
    }

    static bool IsPerfect(int n)
    {
        int s = 0;
        for (int i = 1; i < n; i++) if (n % i == 0) s += i;
        return s == n;
    }

    static bool IsAbundant(int n)
    {
        int s = 0;
        for (int i = 1; i < n; i++) if (n % i == 0) s += i;
        return s > n;
    }

    static bool IsDeficient(int n)
    {
        int s = 0;
        for (int i = 1; i < n; i++) if (n % i == 0) s += i;
        return s < n;
    }

    static bool IsStrong(int n)
    {
        int sum = 0, temp = n;
        while (temp > 0)
        {
            int d = temp % 10, f = 1;
            for (int i = 1; i <= d; i++) f *= i;
            sum += f;
            temp /= 10;
        }
        return sum == n;
    }
}
