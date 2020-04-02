using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = input.Length;
            
            int counter = 1;

            int bestCounter = 1;
            int element = 0;

            element = input[0];
            for (int index = 0; index < length - 1; index++)
            {
                for (int i = index + 1; i < length; i++)
                {
                    if (input[index] == input[i])
                    {
                        counter++;
                        if (counter > bestCounter)
                        {
                            bestCounter = counter;
                            element = input[index];
                        }
                    }
                }
                counter = 1;
            }
            Console.WriteLine(element);
        }
    }
}
