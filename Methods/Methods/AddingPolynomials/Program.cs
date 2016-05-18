using System;

class Program
{
    static void Polynomials(int size, string firstArr, string secondArr)
    {
        string[] firstStringArr = firstArr.Split(' ');
        string[] secondStringArr = secondArr.Split(' ');
        int[] firstIntArr = Array.ConvertAll<string, int>(firstStringArr, int.Parse);
        int[] secondIntArr = Array.ConvertAll<string, int>(secondStringArr, int.Parse);

        for (int i = 0; i < firstIntArr.Length; i++)
        {
            firstIntArr[i] += secondIntArr[i];
        }
        for (int i = 0; i < firstIntArr.Length; i++)
        {
            Console.Write(firstIntArr[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string firstArr = Console.ReadLine();
        string secondArr = Console.ReadLine();
        Polynomials(size, firstArr, secondArr);
    }
}

