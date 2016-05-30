using System;



class Program
{
    static void Main()
    {
        double input = 0;
        try
        {
            input = double.Parse(Console.ReadLine());
            if (input < 0)
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine("Good bye");
            }
            else
            {
                input = Math.Sqrt(input);
                Console.WriteLine("{0:F3}", input);
                Console.WriteLine("Good bye");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
            Console.WriteLine("Good bye");
        }
    }
}

