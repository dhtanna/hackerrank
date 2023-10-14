using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions
{
    public class LeftRotation
    {
        // https://www.hackerrank.com/challenges/array-left-rotation/problem?isFullScreen=true

        internal void TakeInput()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = rotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));

            Console.ReadKey();
        }

        private List<int> rotateLeft(int d, List<int> arr)
        {
            List<int> extractedNumbers = new List<int>();
            int j = 0;
            int swapped = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (i < d)
                {
                    extractedNumbers.Add(arr[i]);
                }
                else
                {
                    swapped++;
                    arr[j++] = arr[i];
                }
            }

            j = 0;

            for (int i = swapped; i < arr.Count; i++)
            {
                arr[i] = extractedNumbers[j++];
            }

            return arr;
        }
    }
}
