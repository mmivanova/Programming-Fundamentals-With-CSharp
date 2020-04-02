using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] condensed;
            while (input.Length > 1)
            {
                condensed = new int[input.Length - 1];
                for (int index = 0; index < input.Length - 1 ; index++)
                {
                    condensed[index] = input[index] + input[index + 1];
                }
                input = condensed;
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
