using System;

class Program
{
    public static void Main()
    {
        double cp= 129;
        double sp= 191;
        double profit=sp-cp;
        double profit_percentage=(profit/cp)*100;
        Console.WriteLine("The Cost Price is INR"+cp+"and Selling Price is INR"+sp+"\n"+
        "The Profit is INR"+profit+"and the Profit Percentage is"+profit_percentage);
    }
}