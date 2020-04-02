using System;
using System.Linq;

namespace Rounding_Numbers_Away_From_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = 
                Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                double result = Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(array[i] + " => " + result);
            }

        }
    }
}
