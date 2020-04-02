using System;
using System.Linq;

namespace Pairs_By_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            Array.Sort(input);

            int length = input.Length;

            int pairs = 0;

            for (int index = 0; index < length - 1; index++)
            {
                for (int i = index + 1; i < length; i++)
                {
                    if (input[index] + difference == input[i])
                    {
                        pairs++;
                    }
                }
            }
            Console.WriteLine(pairs);
        }
    }
}
