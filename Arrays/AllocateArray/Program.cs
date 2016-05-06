using System;

class Program
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numArr = new int[numberN];

        for (int i = 0; i < numberN; i++)
        {
            numArr[i] = i * 5;
            Console.WriteLine(numArr[i]);
        }
    }
}
