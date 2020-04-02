using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = input.Length;

            int rightSum = 0;
            int leftSum = 0;

            bool sumAreEqual = true;

            for (int index = 0; index < length; index++)
            {
                for (int rightIndexes = 0; rightIndexes < index; rightIndexes++)
                {
                    rightSum += input[rightIndexes];
                }
                for (int leftIndexes = index + 1; leftIndexes < length; leftIndexes++)
                {
                    leftSum += input[leftIndexes];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(index);
                    sumAreEqual = false;
                    break;
                }
                rightSum = 0;
                leftSum = 0;
            }
            if (sumAreEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
