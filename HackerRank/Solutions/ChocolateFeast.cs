using System;

namespace HackerRank.Solutions
{
    public class ChocolateFeast
    {
        // https://www.hackerrank.com/challenges/chocolate-feast/problem?isFullScreen=true

        internal void TakeInput()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int c = Convert.ToInt32(firstMultipleInput[1]);

                int m = Convert.ToInt32(firstMultipleInput[2]);

                int result = chocolateFeast(n, c, m);

                Console.WriteLine(result);
            }
        }

        static int chocolateFeast(int n, int c, int m)
        {
            int w = 0, numberOfC = 0;

            numberOfC = n / c;

            w = numberOfC;

            while (w >= m)
            {
                int purchased = w / m;

                w = purchased + w % m;

                numberOfC += purchased;
            }

            return numberOfC;
        }

        static int calculateNumberOfC(int numberOfC, int n, int c, int w)
        {
            numberOfC += n / c;
            w += n / c;
            w += n % c;

            return numberOfC;
        }
    }
}
