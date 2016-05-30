using System;

class Program
{
    static string[] Input(int repeat)
    {
        string[] input = new string[repeat];
        for (int i = 0; i < repeat; i++)
        {
            input[i] = Console.ReadLine();
        }

        return input;
    }
    static string[] Rearange(string[] input)
    {
        int counter = 0;
        string[] result = new string[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            int position = input[i].Length % (counter + 1);
            counter++;
            result[position] = input[i];
        }
        return result;
    }
    static void Main()
    {
        string[] input = Input(int.Parse(Console.ReadLine()));
        string[] result = Rearange(input);
        Console.WriteLine(result[1]);
    }
}

