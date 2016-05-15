using System;

class Program
{
    static void SumArrays(int sizeFirst, int sizeSecond, string firstNumArr, string secondNumArr)
    {
        int plusSize = 0;
        int[] result;
        int[] small;
        int maxSize = 0;
        bool isFirstBigger = false;
        if (sizeFirst > sizeSecond)
        {
            plusSize = sizeSecond;
            maxSize = sizeFirst;
            isFirstBigger = true;
        }
        else
        {
            plusSize = sizeFirst;
            maxSize = sizeSecond;
            isFirstBigger = false;
        }
        string[] strFristNumArr = firstNumArr.Split(' ');
        string[] strSecondNumArr = secondNumArr.Split(' ');
        int[] intFirstNumArr = Array.ConvertAll<string, int>(strFristNumArr, int.Parse);
        int[] intSecondNumArr = Array.ConvertAll<string, int>(strSecondNumArr, int.Parse);
        if (isFirstBigger == true)
        {
            result = intFirstNumArr;
            small = intSecondNumArr;
        }
        else
        {
            result = intSecondNumArr;
            small = intFirstNumArr;
        }

        for (int i = 0; i < plusSize; i++)
        {
            result[i] += small[i];
        }
        for (int i = 0; i < maxSize; i++)
        {
            if (result[i] >= 10)
            {
                result[i] -= 10;
                result[i + 1] += 1;
            }
        }
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string size = Console.ReadLine();
        string[] sizeArr = size.Split(' ');
        int[] sizeIntArr = Array.ConvertAll<string, int>(sizeArr, int.Parse);
        string firstNumArr = Console.ReadLine();
        string seconNumArr = Console.ReadLine();
        SumArrays(sizeIntArr[0], sizeIntArr[1], firstNumArr, seconNumArr);
    }
}

