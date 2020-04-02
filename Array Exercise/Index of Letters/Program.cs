using System;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            int length = input.Length;

            for (int index = 0; index < length; index++)
            {
                Console.WriteLine(input[index] + " -> " + GetNumber(input[index]));
            }
        }
        static int GetNumber(char charche)
        {
            return (int)charche - 97;
        }
    }
}
