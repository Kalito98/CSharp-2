using System;

class Program
{
    static void ReverseNumber(string number)
    {
        char[] digit = number.ToCharArray();
        Array.Reverse(digit);
        Console.WriteLine(digit);
    }

    static void Main()
    {
        ReverseNumber(Console.ReadLine());

    }
}

