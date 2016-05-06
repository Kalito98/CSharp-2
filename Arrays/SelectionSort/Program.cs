using System;

class Program
{
    static void Main()
    {
        int sizeArr = int.Parse(Console.ReadLine());
        int[] intArr = new int[sizeArr];

        for (int i = 0; i < sizeArr; i++)
        {
            intArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(intArr);
        for (int j = 0; j < sizeArr; j++)
        {
            Console.WriteLine(intArr[j]);
        }
    }
}

