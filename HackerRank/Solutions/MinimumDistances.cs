using System;

namespace HackerRank.Solutions
{
    public class MinimumDistances
    {
        //https://www.hackerrank.com/challenges/minimum-distances/problem?h_r=next-challenge&h_v=zen

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int result = MinimumDistancesFn(a);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int MinimumDistancesFn(int[] a)
        {
            int minimumValue = -1, n = a.Length;

            #region Validation
            if (a == null)
                throw new ArgumentNullException(nameof(a));

            if (a.Length == 0)
                throw new ArgumentException("Values are required.", nameof(a));
            #endregion

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        int difference = j - i;

                        if (minimumValue == -1)
                        {
                            minimumValue = difference;
                        }
                        else if(difference < minimumValue)
                        {
                            minimumValue = difference;
                        }
                    }
                }
            }

            return minimumValue;
        }
    }
}
