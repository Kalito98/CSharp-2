using System;

class Program
{
    static void SortArray(int size, string numbers)
    {
        string[] strNumbers = numbers.Split(' ');
        int[] intNumbers = Array.ConvertAll<string, int>(strNumbers, int.Parse);
        Array.Sort(intNumbers);
        for (int i = 0; i < intNumbers.Length; i++)
        {
            Console.Write(intNumbers[i] + " ");
        }
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        SortArray(size, numbers);
    }
}

