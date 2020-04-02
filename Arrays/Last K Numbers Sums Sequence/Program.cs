using System;

namespace Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] seqence = new int[n];

            seqence[0] = 1;
            int sum = 0; 
            for (int i = 1; i < seqence.Length; i++)
            {
                if (i - k < 0)
                {
                    for (int j = 0; j < k - 1; j++)
                    {
                        sum += seqence[j];

                    }
                    seqence[i] = sum;
                }
                else
                {

                    for (int m = i - k; m < seqence.Length; m++)
                    {
                        sum += seqence[m];

                    }
                    seqence[i] = sum;
                }
                sum = 0;

            }
            Console.WriteLine(String.Join(" ", seqence));
        }
    }
}
