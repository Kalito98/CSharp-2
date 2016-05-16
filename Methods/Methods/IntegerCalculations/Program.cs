using System;
using System.Numerics;

class Program
{
    static void Minimum(int[] numbers)
    {
        Array.Sort(numbers);
        Console.WriteLine(numbers[0]);
    }
    static void Maximum(int[] numbers)
    {
        Array.Sort(numbers);
        Console.WriteLine(numbers[4]);
    }
    static void Avarage(int[] numbers)
    {
        double result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        result /= numbers.Length;
        Console.WriteLine("{0:F2}", result);
    }
    static void Sum(int[] numbers)
    {
        double result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        Console.WriteLine(result);
    }
    static void Product(int[] numbers)
    {
        BigInteger result = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        Console.WriteLine(result);
    }
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] numbersStrArr = numbers.Split(' ');
        int[] numbersIntArr = Array.ConvertAll<string, int>(numbersStrArr, int.Parse);
        Minimum(numbersIntArr);
        Maximum(numbersIntArr);
        Avarage(numbersIntArr);
        Sum(numbersIntArr);
        Product(numbersIntArr);
    }
}

