using System;

class Program
{
    static void Main()
    {
        string one = Console.ReadLine();
        string two = Console.ReadLine();
        one = one.ToLower();
        two = two.ToLower();
        char[] arr1 = one.ToCharArray();
        char[] arr2 = two.ToCharArray();

        if (arr1.Length > arr2.Length)
        {
            Console.WriteLine(">");
        }
        if (arr1.Length < arr2.Length)
        {
            Console.WriteLine("<");
        }
        if (arr1.Length == arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] )
                {

                }
            }
        }
    }
}

