using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions
{
    public class BirthdayChocolate
    {
        //https://www.hackerrank.com/challenges/the-birthday-bar/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        private int birthday(List<int> s, int d, int m)
        {
            int result=0;
            if (m == 1)
            {
                return 1;
            }

            for (int i = 0; i <= s.Count - m; i++)
            {
                List<int> iteratorElements = s.GetRange(i, m);
                int sum = 0;
                for (int j = 0; j < iteratorElements.Count; j++)
                {
                    sum += iteratorElements[j];
                }

                if (sum == d)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
