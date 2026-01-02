using System;

class HandshakesDirect
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine($"Possible handshakes = {handshakes}");
    }
}
