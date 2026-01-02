using System;

class Program
{
    static void Main()
    {
        double fee = 125000;
        double discount_percentage=10;
        double discount_amount=0.10*125000;
        double final_fees=fee-discount_amount;
        Console.WriteLine("The discount amount is INR"+discount_amount+" and final discounted fee is INR"+final_fees);
    }
}