using System;

class Program
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());
        double answer = (length * altitude) / (double)2;
        Console.WriteLine("{0:F2}", answer);
    }
}

