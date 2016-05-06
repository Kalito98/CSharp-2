using System;

class Program
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 97; i < 123; i++)
        {
            alphabet[i - 97] = (char)i;
        }
        string input = Console.ReadLine();

        for (int j = 0; j < input.Length; j++)
        {
            for (int k = 0; k < 26; k++)
            {
                if (input[j] == alphabet[k])
                {
                    Console.WriteLine(k);
                    break;
                }
            }
        }
    }
}

