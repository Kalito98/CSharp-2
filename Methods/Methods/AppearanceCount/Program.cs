using System;

class Program
{
    static void Count(int size, string[] numbers, int appNumber)
    {
        int[] numberArr = Array.ConvertAll<string, int>(numbers, int.Parse);
        int maxCount = 0;
        for (int i = 0; i < size; i++)
        {
            if (numberArr[i] == appNumber)
            {
                maxCount++;
            }
        }
        Console.WriteLine(maxCount);
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        string[] numArr = numbers.Split(' ');
        int appNumber = int.Parse(Console.ReadLine());
        Count(size, numArr, appNumber);
    }
}

