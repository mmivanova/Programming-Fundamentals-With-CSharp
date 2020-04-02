using System;
using System.Linq;

namespace Equal_Elements_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = inputArray.Length;

            int currentElement = 0;
            int currentLength = 1;

            int bestElement = 0;
            int bestLength = 1;

            currentElement = inputArray[length - 1];
            for (int index = length - 1; index > 0; index--)
            {
                if (inputArray[index] == inputArray[index - 1])
                {
                    currentElement = inputArray[index];
                    currentLength++;
                    if (currentLength >= bestLength)
                    {
                        bestLength = currentLength;
                        bestElement = inputArray[index];
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(bestElement + " ");
            }
        }
    }
}
