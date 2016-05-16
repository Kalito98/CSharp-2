using System;
using System.Numerics;

class Program
{
    static void Factorial(int number)
    {
        BigInteger result = number;
        for (int i = 1; i < number; i++)
        {
            result *= i;
        }
        if (number == 0)
        {
            result = 1;
        }
        Console.WriteLine(result);
    }

    static void Main()
    {
        Factorial(int.Parse(Console.ReadLine()));
    }
}

