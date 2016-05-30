using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int UsePattern(int[] valley)
    {
        //read
        char[] separator = new char[] { ' ', ',' };
        string input = Console.ReadLine();
        string[] inputArr = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[inputArr.Length];
        for (int i = 0; i < inputArr.Length; i++)
        {
            pattern[i] = int.Parse(inputArr[i]);
        }
        //magic
        int[] valleyRepeat = new int[valley.Length];
        Array.Copy(valley, valleyRepeat, valley.Length);
        bool stop = false;
        int currentPosition = 0;
        int lastPosition = 0;
        int result = valley[0];
        int counter = 0;
        while (stop == false)
        {
            currentPosition += pattern[counter];
            if (currentPosition < 0 || currentPosition > valleyRepeat.Length || valleyRepeat[currentPosition] == 1001)
            {
                break;
            }
            result += valleyRepeat[currentPosition];
            valleyRepeat[currentPosition] = 1001;
            counter++;
            if (counter == pattern.Length)
            {
                counter = 0;
            }
        }
        return result;
    }

    static void Main()
    {
        char[] separator = new char[] { ' ', ',' };
        string input = Console.ReadLine();
        string[] inputArr = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int[] valleya = new int[inputArr.Length];
        for (int i = 0; i < inputArr.Length; i++)
        {
            valleya[i] = int.Parse(inputArr[i]);
        }
        int repeat = int.Parse(Console.ReadLine());
        int[] results = new int[repeat];
        int result = 0;
        int currentResult = 0;
        for (int i = 0; i < repeat; i++)
        {
            currentResult = UsePattern(valleya);
            if (currentResult > result)
            {
                result = currentResult;
            }
        }
        Console.WriteLine(result);
    }
}

