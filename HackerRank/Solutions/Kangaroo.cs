using System;

namespace HackerRank.Solutions
{
    public class Kangaroo
    {
        //https://www.hackerrank.com/challenges/kangaroo/problem
        internal void TakeInput()
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x2 > x1 && v2 > v1)
            {
                return "NO";

            }
            int firstKangarooLocation = x1 + v1, secondKangarooLocation = x2 + v2, firstKangaroTotalJump = 0, secondKangaroTotalJump = 0;

            while (firstKangarooLocation != secondKangarooLocation)
            {
                firstKangarooLocation = firstKangarooLocation + v1;
                secondKangarooLocation = secondKangarooLocation + v2;
                firstKangaroTotalJump++;
                secondKangaroTotalJump++;

                if (firstKangarooLocation >= 100000000 || secondKangarooLocation >= 100000000)
                {
                    return "NO";
                }

            }

            if ((firstKangarooLocation == secondKangarooLocation && firstKangaroTotalJump == secondKangaroTotalJump))
            {
                return "YES";
            }

            return "NO";
        }
    }
}
