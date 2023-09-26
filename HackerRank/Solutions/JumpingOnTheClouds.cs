using System;

namespace HackerRank.Solutions
{
    public class JumpingOnTheClouds
    {
        // https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int jumpingOnClouds(int[] c)
        {
            int result = 0;

            for (int i = 0; i < c.Length - 1;)
            {
                int cloudsToJump = c.Length > (i + 2) ? i + 2 : c.Length > i + 1 ? i + 1 : i;

                if (c[cloudsToJump] == 1)
                {
                    i = i + 1;
                }
                else
                {
                    i = i + 2;
                }
                result++;
            }

            return result;
        }
    }
}
