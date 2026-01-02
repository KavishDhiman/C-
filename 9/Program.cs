using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student fee: ");
        double fee = double.Parse(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        double discountPercent = double.Parse(Console.ReadLine());

        double discountAmount = (fee * discountPercent) / 100;
        double finalFee = fee - discountAmount;

        Console.WriteLine("The discount amount is INR " + discountAmount);
        Console.WriteLine("The final discounted fee is INR " + finalFee);
    }
}
