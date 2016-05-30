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
        string[] result = new string[input.Length + 1];
        for (int i = 0; i < input.Length; i++)
        {
            int position = (input[i].Length % (input.Length + 1));
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

