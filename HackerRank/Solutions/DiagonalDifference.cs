using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions
{
    public class DiagonalDifference
    {
        // https://www.hackerrank.com/challenges/diagonal-difference/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int diagonalDifference(List<List<int>> arr)
        {
            int leftDiagonal, rightDiagonal, n;

            leftDiagonal = rightDiagonal = 0;
            n = arr.Count;

            for (int i = 0; i < n; i++)
            {
                leftDiagonal += arr[i][i];
                int j = n - i - 1;
                rightDiagonal += arr[i][j];
            }

            return Math.Abs(leftDiagonal - rightDiagonal);
        }
    }
}
