using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static string[] SplitBy3(string input)
    {
        int lenght = input.Length / 3;
        int counter = 0;
        string[] result = new string[lenght];
        for (int i = 0; i < lenght * 3; i += 3)
        {
            result[counter] += input[i];
            result[counter] += input[i + 1];
            result[counter] += input[i + 2];
            counter++;
        }
        return result;
    }

    static void Main()
    {
        double result = 0;
        int counter = 1;
        string[] keyWords = new string[] { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        string input = Console.ReadLine();
        string[] inputArr = SplitBy3(input);
        int power = inputArr.Length - 1;
        for (int i = 0; i < inputArr.Length; i++)
        {
            for (int j = 0; j < keyWords.Length; j++)
            {
                if (inputArr[i] == keyWords[j])
                {
                    result += j * Math.Pow(13, power);
                    power--;
                }
            }
        }
        Console.WriteLine(result);
    }
}

