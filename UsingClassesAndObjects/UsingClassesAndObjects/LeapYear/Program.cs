using System;

class Program
{
    static void Main()
    {
        bool isLeap = DateTime.IsLeapYear(int.Parse(Console.ReadLine()));
        if (isLeap == true)
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}

