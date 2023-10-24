using System;

namespace HackerRank.Solutions
{
    // https://leetcode.com/problems/build-array-from-permutation/

    public class ArrayFromPermutation
    {
        internal void TakeInput()
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] result = GetPermutation(a);

        }

        private int[] GetPermutation(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[result[i]];
            }

            return result;
        }
    }
}
