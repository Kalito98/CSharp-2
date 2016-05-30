using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        bool ifTure = false;
        int[] input = new int[10];
        for (int i = 0; i < 10; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 8; i++)
        {
            if (input[i + 1] > input[i])
            {
                continue;
            }
            else
            {
                ifTure = true;
                break;
            }
        }
        if (ifTure == true || input[0] == 1 || input[9] == 100)
        {
            Console.WriteLine("Exception");
        }
        else
        {
            Console.Write("1 < ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(input[i]);
                if (i < 10)
                {
                    Console.Write(" < ");
                }
            }
            Console.Write("100 ");
        }
    }
}

