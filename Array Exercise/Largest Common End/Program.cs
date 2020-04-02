using System;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ');
            string[] arrayTwo = Console.ReadLine().Split(' ');

            int length = Math.Min(arrayOne.Length, arrayTwo.Length);

            int sumOne = 0;
            int sumTwo = 0;

            for (int index = 0; index < length; index++)
            {
                if (arrayOne[index] == arrayTwo[index])
                {
                    sumOne++;
                }
            }

            Array.Reverse(arrayOne);
            Array.Reverse(arrayTwo);

            for (int index = 0; index < length; index++)
            {
                if (arrayOne[index] == arrayTwo[index])
                {
                    sumTwo++;
                }
            }

            int sum = Math.Max(sumOne, sumTwo);
            Console.WriteLine(sum);
        }
    }
}
