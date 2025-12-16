using System;

class ATMSystem
{
    static void Main()
    {
        Console.Write("Enter account balance: ");
        int balance = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter withdrawal amount: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        int minimumBalance = 1000;
        int dailyLimit = 20000;

        if (balance - amount >= minimumBalance)
        {
            if (amount <= dailyLimit)
            {
                Console.WriteLine("Withdrawal Successful");
            }
            else
            {
                Console.WriteLine("Withdrawal Rejected: Exceeds daily limit");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal Rejected: Minimum balance of ₹1000 must be maintained");
        }
    }
}
