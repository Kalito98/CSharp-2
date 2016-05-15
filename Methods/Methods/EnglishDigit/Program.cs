using System;


class Program
{
    static void LastDigitWord(int number)
    {
        int lastDigit = number % 10;
        string[] digits = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        Console.WriteLine(digits[lastDigit]);
    }
    static void Main()
    {
        LastDigitWord(int.Parse(Console.ReadLine()));
    }
}

