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
                Console.WriteLine(i);
                counter++;
                break;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("-1");
        }
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        string[] numbersStrArr = numbers.Split(' ');
        CheckIfLarger(size, numbersStrArr);
    }
}
