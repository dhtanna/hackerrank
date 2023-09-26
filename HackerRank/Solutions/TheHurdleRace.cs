using System;
using System.Linq;

namespace HackerRank.Solutions
{
    public class TheHurdleRace
    {
        //https://www.hackerrank.com/challenges/the-hurdle-race/problem

        internal void TakeInput()
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int hurdleRace(int k, int[] height)
        {
            int maximumHeight = 0;

            for (int i = 0; i < height.Length; i++)
            {
                int currentNumber = height[i];
                if (currentNumber > maximumHeight)
                    maximumHeight = currentNumber;
            }

            if (maximumHeight <= k)
            {
                return 0;
            }
            return maximumHeight - k;
        }
    }
}
