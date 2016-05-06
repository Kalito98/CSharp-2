using System;

class Program
{
    static void Main()
    {
        int sizeArr = int.Parse(Console.ReadLine());
        int[] intArr = new int[sizeArr];
        int maxNum = 0;
        int curNum = 0;
        int maxFreq = 0;
        int curFreq = 1;
        int lastNum = 0;

        for (int i = 0; i < sizeArr; i++)
        {
            intArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(intArr);
        for (int j = 0; j < sizeArr; j++)
        {
            if (lastNum != intArr[j])
            {
                curFreq = 1;
            }
            else
            {
                curFreq++;
            }
            if (curFreq > maxFreq)
            {
                maxFreq = curFreq;
                maxNum = intArr[j];
            }
            lastNum = intArr[j];
        }
        Console.WriteLine("{0} ({1} times)", maxNum, maxFreq);
    }
}


