using System;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool noMatches = true;
            for (int index = 0; index < array.Length; index++)
            {
                for (int addend = index + 1; addend < array.Length; addend++)
                {
                    int sum = array[index] + array[addend];
                    for (int element = 0; element < array.Length; element++)
                    {
                        if (array[element] == sum)
                        {
                            Console.WriteLine(array[index] + " + " + array[addend] + " == " + array[element]);
                            noMatches = false;
                        }

                    }
                }
            }
            if (noMatches)
            {
                Console.WriteLine("No");
            }
        }
    }
}
