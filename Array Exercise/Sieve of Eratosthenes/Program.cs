using System;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPrime(int number)
        {
            bool isPrimeFlag = true;
            
            if (number == 1)
            {
                isPrimeFlag = false;
                return isPrimeFlag;
            }


            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrimeFlag = false;
                    break;
                }
            }

            return isPrimeFlag;
        }
    }
}
