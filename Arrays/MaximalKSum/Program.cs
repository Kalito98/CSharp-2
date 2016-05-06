using System;
using System.Linq;   

class Program
{
    static void Main()
    {
        int sizeArr = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());
        int[] numArr = new int[sizeArr];
        int sum = 0;

        for (int i = 0; i < sizeArr; i++)
        {
            numArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numArr);
        for (int j = sizeArr - 1; j >= sizeArr - numK; j--)
        {
            sum += numArr[j];
        }
        Console.WriteLine(sum);
    }
}

