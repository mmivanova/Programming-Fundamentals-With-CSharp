using System;
using System.Linq;

namespace Increasing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = input.Length;

            int currentElement = 0;
            int currentLength = 1;

            int bestElement = 0;
            int bestStart = 1;

            currentElement = input[0];
            for (int index = 0; index < length - 1; index++)
            {
                if (input[index] == input[index + 1])
                {
                    currentElement = input[index];
                    currentLength++;
                    if (currentLength > bestElement)
                    {
                        bestStart = currentLength;
                        bestElement = input[index];
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            for (int i = 0; i < bestStart; i++)
            {
                Console.WriteLine(bestElement + i + " ");
            }
        }
    }
}
