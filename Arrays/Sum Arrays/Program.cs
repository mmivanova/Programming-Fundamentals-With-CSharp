using System;
using System.Linq;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arrayTwo =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int length = Math.Max(arrayOne.Length, arrayTwo.Length);

            int[] sumArray = new int[length];
            if(arrayOne.Length < arrayTwo.Length)
            {
                arrayOne = ResizeArray(arrayOne, length);
            }
            else if (arrayOne.Length > arrayTwo.Length)
            {
                arrayTwo = ResizeArray(arrayTwo, length);
            }


            for (int index  = 0; index < length; index++)
            {
                sumArray[index] = arrayOne[index] + arrayTwo[index];
            }


            Console.WriteLine(String.Join(" ", sumArray));
        }

        static int[] ResizeArray(int[] array, int length)
        {
            int oldLength = array.Length;
            Array.Resize<int>(ref array, length);
            for (int index = oldLength; index < length; index++)
            {
                array[index] = array[index - oldLength];
            }

            return array;
        }
    }
}
