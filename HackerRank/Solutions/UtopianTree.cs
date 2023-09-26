using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class UtopianTree
    {
        //https://www.hackerrank.com/challenges/utopian-tree/problem?h_r=next-challenge&h_v=zen

        internal void TakeInput()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                Console.WriteLine(result);
                Console.ReadLine();
            }

        }

        private int utopianTree(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            var numberOfSprings = Enumerable.Range(1, n).ToList();
            int totalHeight = 1;

            for (int i = 0; i < numberOfSprings.Count; i++)
            {
                int currentSpring = numberOfSprings[i];

                if (currentSpring % 2 == 0)
                {
                    totalHeight = totalHeight + 1;
                }
                else
                {
                    totalHeight = totalHeight * 2;
                }
            }

            return totalHeight;
        }
    }
}
