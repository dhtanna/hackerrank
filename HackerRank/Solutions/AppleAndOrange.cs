using System;

namespace HackerRank.Solutions
{
    public class AppleAndOrange
    {
        //https://www.hackerrank.com/challenges/apple-and-orange/problem

        internal void TakeInput()
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
            Console.ReadLine();
        }

        private void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleFallingCount = 0, orangeFallingCount = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                int appleFallingDistance = apples[i];
                int differenceOfAppleFallFromOrigin = appleFallingDistance + a;
                if (appleFallingDistance > 0 && differenceOfAppleFallFromOrigin >= s && differenceOfAppleFallFromOrigin <= t)
                {
                    appleFallingCount++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                int orangeFallingDistance = oranges[i];

                if (orangeFallingDistance < 0)
                {
                    int differenceOfOrangeFallFromOrigin = b - Math.Abs(orangeFallingDistance);

                    if (s <= differenceOfOrangeFallFromOrigin && t >= differenceOfOrangeFallFromOrigin)
                    {
                        orangeFallingCount++;
                    } 
                }
            }

            Console.WriteLine(appleFallingCount);
            Console.WriteLine(orangeFallingCount);
        }
    }
}
