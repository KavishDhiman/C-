class OTP
{
    static int GenerateOTP() => new Random().Next(100000, 999999);

    static bool IsUnique(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] == arr[j]) return false;
        return true;
    }
}
