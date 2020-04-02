using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = array.Length;
            int k = length / 4;
            int[] firstRow = new int[k];
            int[] secondRow = new int[length / 2];

            for (int index = 0; index < k; index++)
            {
                firstRow[index] = array[index];
            }

            Array.Reverse(firstRow);
            Array.Resize<int>(ref firstRow, length / 2);
            Array.Reverse(firstRow);

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = array[i + length - k];
            }
            Array.Reverse(firstRow);

            for (int index = 0; index < length / 2; index++)
            {
                secondRow[index] = array[index + k];
            }

            int[] sum = new int[length / 2];
            for (int index = 0; index < sum.Length; index++)
            {
                sum[index] = firstRow[index] + secondRow[index];
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
