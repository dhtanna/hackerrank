using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HackerRank.Solutions
{
    public class EqualizeTheArray
    {
        // https://www.hackerrank.com/challenges/equality-in-a-array/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            // 7 8 7 8 6 7 5 7 4 7
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int result = EqualizeArray(arr);
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int EqualizeArray(int[] arr)
        {
            #region Validations
            if (arr == null)
                throw new ArgumentNullException();
            if (arr.Length == 0)
                throw new ArgumentException("Value is required", nameof(arr));
            #endregion

            Dictionary<int, int> pairs = new Dictionary<int, int>();
            int n = arr.Length, maxValue = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentValue = arr[i];
                if (pairs.ContainsKey(currentValue))
                {
                    int existingValue = pairs[currentValue] + 1;
                    pairs[currentValue] = existingValue;

                    if (existingValue > maxValue)
                        maxValue = existingValue;
                }
                else
                    pairs.Add(currentValue, 1);
            }
            return n - maxValue;
        }
    }
}
