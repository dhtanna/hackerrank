using System;

namespace HackerRank.Solutions
{


    /// <summary>
    /// Given an unsorted array A of size N of non-negative integers, find a continuous sub-array which adds to a given number S.
    ///
    ///Input:
    ///The first line of input contains an integer T denoting the number of test cases.
    ///Then T test cases follow.Each test case consists of two lines.The first line of each test case is N and S, where N is the size of array and S is the sum. 
    ///The second line of each test case contains N space separated integers denoting the array elements.
    ///
    ///Output:
    ///For each testcase, in a new line, print the starting and ending positions(1 indexing) of first such occuring subarray from the left
    ///if sum equals to subarray, else print -1.
    ///
    ///Constraints:
    ///1 <= T <= 100
    ///1 <= N <= 107
    ///1 <= Ai <= 1010
    ///
    ///Example:
    ///Input:
    ///2
    ///5 12
    ///1 2 3 7 5
    ///10 15
    ///1 2 3 4 5 6 7 8 9 10
    ///Output:
    ///2 4
    ///1 5
    ///
    ///Explanation :
    ///Testcase1: sum of elements from 2nd position to 4th position is 12
    ///Testcase2: sum of elements from 1st position to 5th position is 15
    /// </summary>
    public class SubArrayWithGivenSum
    {
        internal void TakeInput()
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            if (numberOfTestCases > 0)
            {
                string[] result = new string[numberOfTestCases];
                int resultIterator = 0;
                while (numberOfTestCases != 0)
                {
                    string[] ns = Console.ReadLine().Split(' ');
                    int n = Convert.ToInt32(ns[0]);
                    decimal sum = Convert.ToDecimal(ns[1]);

                    int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), temp => Convert.ToInt32(temp));

                    result[resultIterator++] = SumWithGivenArray(n, sum, array);

                    numberOfTestCases--;
                }

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i]);
                }
                Console.ReadLine();
            }
        }

        private string SumWithGivenArray(int n, decimal sum, int[] array)
        {
            int startPosition = 0, endPosition = 0, startingValue = 0;

            #region Validation
            if (array == null)
                throw new ArgumentNullException();

            if (array.Length == 0)
                throw new ArgumentException("Parameter is empty", nameof(array));

            if (n != array.Length)
                throw new ArgumentException("N and Array's values are not matching");
            #endregion

            bool run = true;
            while (run)
            {
                startPosition = startingValue + 1;
                int tempSum = 0;
                bool loopBreaked = false;
                for (int i = startingValue; i < n; i++)
                {
                    tempSum += array[i];

                    if (tempSum == sum)
                    {
                        endPosition = i + 1;
                        run = false;
                        loopBreaked = true;
                        break;
                    }
                    else if (tempSum > sum)
                    {
                        loopBreaked = true;
                        break;
                    }
                }
                if(!loopBreaked)
                {
                    return "-1";
                }
                startingValue++;
            }

            return startPosition.ToString() + ' ' + endPosition.ToString();
        }
    }
}
