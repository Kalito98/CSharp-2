using System;

class Program
{
    static void CheckIfLarger(int size, string[] numbers)
    {
        int counter = 0;
        int[] numberArr = Array.ConvertAll<string, int>(numbers, int.Parse);
        for (int i = 1; i < size - 1; i++)
        {
            if (numberArr[i] > numberArr[i + 1] && numberArr[i] > numberArr[i - 1])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        string[] numbersStrArr = numbers.Split(' ');
        CheckIfLarger(size, numbersStrArr);
    }
}

