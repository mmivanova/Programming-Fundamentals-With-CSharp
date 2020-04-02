using System;
using System.Linq;

namespace Extract_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintElements();
        }

        static void PrintElements()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = array.Length;

            if (length == 1)
            {
                Console.WriteLine(array[0]);
            }
            else if (length % 2 == 0)
            {
                Console.WriteLine(array[length / 2 - 1] + ", " + array[length / 2]);
            }
            else if (length % 2 == 1)
            {
                Console.WriteLine(array[length / 2 - 1] + ", " + array[length / 2] + ", " + array[length / 2 + 1]);
            }
        }
    }
}
