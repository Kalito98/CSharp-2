using System;

class Program
{
    static void Main()
    {
        int sizeArr = int.Parse(Console.ReadLine());
        int[] arr = new int[sizeArr];
        int maxSeq = 0;
        int curSeq = 1;
        int lastNum = 0;
        for (int i = 0; i < sizeArr; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < sizeArr; j++)
        {
            if (arr[j] <= lastNum)
            {
                curSeq = 1;
                lastNum = arr[j];
            }
            else
            {
                curSeq++;
                lastNum = arr[j];
            }
            if (curSeq > maxSeq)
            {
                maxSeq = curSeq;
            }
        }
        Console.WriteLine(maxSeq);
    }
}

