using System;

class Program
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] intArr = new int[arrSize];

        for (int i = 0; i < arrSize; i++)
        {
            intArr[i] = int.Parse(Console.ReadLine());
        }
        int index = int.Parse(Console.ReadLine());
        int numInIndex = Array.BinarySearch(intArr, index);
        if (numInIndex < 0)
        {
            numInIndex = -1;
        }
        Console.WriteLine(numInIndex);

    }
}


