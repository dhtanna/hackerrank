using System;

namespace HackerRank.Solutions
{
    public class InversionOfArray
    {
        //https://practice.geeksforgeeks.org/problems/inversion-of-array-1587115620/1
        internal void TakeInput()
        {
            long n = Convert.ToInt64(Console.ReadLine());
            long[] array = Array.ConvertAll(Console.ReadLine().Split(' '), a => Convert.ToInt64(a));
            long result = InversionCount(array, n);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private long InversionCount(long[] arr, long N)
        {
            long res = 0;

            for (long i = 0; i < N; i++)
                for (long j = i; j < N; j++)
                    if (arr[i] > arr[j])
                        res++;

            return res;
        }
    }
}
