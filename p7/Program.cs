using System;

class Program
{
    static void Main()
    {
        double radiusKm = 6378;
        double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        double radiusMiles = radiusKm / 1.6;
        double volumeMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

        Console.WriteLine("The volume of earth in cubic kilometers is " + volumeKm);
        Console.WriteLine("The volume of earth in cubic miles is " + volumeMiles);
    }
}
