using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = RemoveWhitespace(Console.ReadLine());
            string stringTwo = RemoveWhitespace(Console.ReadLine());

            if (CompareAlphabetically(stringTwo, stringOne) > 0)
            {
                Console.WriteLine(stringTwo);
                Console.WriteLine(stringOne);
            }
            else
            {
                Console.WriteLine(stringOne);
                Console.WriteLine(stringTwo);
            }
            
        }

        private static int CompareAlphabetically(string firstString, string secondString)
        {
            if (firstString == secondString)
            {
                return 0;
            }

            int length = Math.Min(firstString.Length, secondString.Length);

            firstString.ToLower();
            secondString.ToLower();

            for (int i = 0; i < length; i++)
            {
                if (firstString[i] > secondString[i])
                {
                    return -1;
                }
                else if (firstString[i] < secondString[i])
                {
                    return 1;
                }
            }
            
            if (firstString.Length > secondString.Length)
            {
                return -1;
            }
            else 
            {
                return 1;
            }

        }

        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
