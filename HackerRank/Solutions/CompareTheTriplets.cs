using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions
{
    public class CompareTheTriplets
    {
        //https://www.hackerrank.com/challenges/compare-the-triplets/problem

        public void TakeInput()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = CompareTriplets(a, b);

            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }

        private List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int> { 0, 0};

            if (a.Count == 0 && b.Count == 0)
            {
                result.Add(0);
                result.Add(0);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int aliceMark = a[i];
                    int bobMark = b[i];

                    if (aliceMark > bobMark)
                    {
                        result[0] += 1;
                    }
                    else if(bobMark > aliceMark)
                    {
                        result[1] += 1;
                    }
                }
            }

            return result;

        }
    }
}
