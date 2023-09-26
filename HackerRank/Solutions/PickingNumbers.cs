using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class PickingNumbers
    {
        //https://www.hackerrank.com/challenges/picking-numbers/problem
        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int pickingNumbers(List<int> a)
        {
            int count = 0;
            int n = a.Count;
            a.Sort();
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = i + 1; j < n; j++)
                {

                    if (a[j] - a[i] <= 1)
                    {
                        count++;
                    }

                }
                if (max < count)
                    max = count;
            }

            return max + 1;
        }
    }
}
