using System;

namespace HackerRank.Solutions
{
    public class DivisibleSumPairs
    {
        // https://www.hackerrank.com/challenges/divisible-sum-pairs/problem

        internal void TakeInput()
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
            Console.ReadLine();

        }

        private int divisibleSumPairs(int n, int k, int[] ar)
        {
            int numberOfPair = 0;

            for (int i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    int currentValue = ar[i], nextValue = ar[j];
                    if (i < j && ((currentValue + nextValue) % k == 0))
                    {
                        numberOfPair++;
                    }
                }
            }

            return numberOfPair;
        }
    }
}
