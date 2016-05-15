using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char type = char.Parse(Console.ReadLine());
        int[,] arr = new int[size, size];
        int counter = 1;
        int rak = 0;

        if (type == 'a')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[j, i] = counter;
                    counter++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j]);
                    if (j != size - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        if (type == 'b')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[j, i] = counter;
                    counter++;
                }
            }
          //  for (int i = 1; i < size; i+=2)
          //  {
          //      counter = (i * size) + 1;
          //      for (int j = 0; j < size; j++)
          //      {
          //          arr[j, i] = counter;
          //          counter++;
          //      }
          //  }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j]);
                    if (j != size - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}

