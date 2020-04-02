using System;
using System.Linq;

namespace Reversed_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = 
                Console.ReadLine()
                .Split(' ');

            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
