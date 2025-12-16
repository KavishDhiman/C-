using System;

class PasswordStrengthChecker
{
    static void Main()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        bool hasDigit = false;
        bool hasSpecial = false;

        foreach (char ch in password)
        {
            if (char.IsDigit(ch))
            {
                hasDigit = true;
            }
            else if (!char.IsLetterOrDigit(ch))
            {
                hasSpecial = true;
            }
        }

        if (password.Length < 8)
        {
            Console.WriteLine("Weak");
        }
        else if (hasDigit && hasSpecial)
        {
            Console.WriteLine("Strong");
        }
        else
        {
            Console.WriteLine("Medium");
        }
    }
}
