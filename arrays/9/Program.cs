using System;

class TwoDToOneD
{
    static void Main()
    {
        Console.Write("Rows: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Cols: ");
        int c = int.Parse(Console.ReadLine());

        int[,] matrix = new int[r, c];
        int[] array = new int[r * c];
        int index = 0;

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
                array[index++] = matrix[i, j];
            }

        foreach (int x in array)
            Console.Write(x + " ");
    }
}
