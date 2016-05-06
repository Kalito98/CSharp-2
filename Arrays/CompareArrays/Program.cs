using System;

class Program
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        int[] arr1 = new int[numberN];
        int[] arr2 = new int[numberN];
        bool equal = true;

        for (int i = 0; i < numberN; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < numberN; j++)
        {
            arr2[j] = int.Parse(Console.ReadLine());
        }
        for (int k = 0; k < numberN; k++)
        {
            if (arr1[k] != arr2[k])
            {
                equal = false;
                break;
            }
        }
        if (equal == true)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}

