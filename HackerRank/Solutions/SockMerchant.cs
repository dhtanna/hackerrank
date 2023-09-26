using System;
using System.Collections.Generic;

namespace HackerRank.Solutions
{
    public class SockMerchant
    {
        //https://www.hackerrank.com/challenges/sock-merchant/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int sockMerchant(int n, int[] ar)
        {
            int numberOfPairs = 0;
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currentValue = ar[i];
                if (pairs.ContainsKey(currentValue))
                {
                    pairs.Remove(currentValue);
                    numberOfPairs++;
                }
                else
                {
                    pairs.Add(currentValue, 1);
                }
            }

            return numberOfPairs;
        }
    }
}
