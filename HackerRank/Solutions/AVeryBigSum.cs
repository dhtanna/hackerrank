using System;

namespace HackerRank.Solutions
{
    public class AVeryBigSum
    {
        //https://www.hackerrank.com/challenges/a-very-big-sum/problem

        internal void TakeInput()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(ar);
        }

        private long aVeryBigSum(long[] ar)
        {
            long result = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }

            return result;
        }
    }
}
