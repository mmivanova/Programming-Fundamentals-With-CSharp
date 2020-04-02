using System;
using System.Linq;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int length = array.Length;

            int[] rotatedArr = new int[length];
            Array.Copy(array, rotatedArr, length);



            int[] sumArray = new int[length];

            for (int rot = 0; rot < rotations; rot++)
            {

                rotatedArr = RotateArray(rotatedArr);

                for (int i = 0; i < length; i++)
                {
                    sumArray[i] += rotatedArr[i];
                }

            }


            Console.WriteLine(String.Join(" ", sumArray));


        }

        private static int[] RotateArray(int[] arrayOne)
        {
            int element = arrayOne[arrayOne.Length - 1];
            for (int i = arrayOne.Length - 1; i > 0; i--)
            {
                arrayOne[i] = arrayOne[i - 1];

            }
            arrayOne[0] = element;
            return arrayOne;
        }
    }
}
