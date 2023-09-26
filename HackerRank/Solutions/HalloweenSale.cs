using System;

namespace HackerRank.Solutions
{
    public class HalloweenSale
    {
        // https://www.hackerrank.com/challenges/halloween-sale/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen

        internal void TakeInput()
        {
            string[] pdms = Console.ReadLine().Split(' ');

            int p = Convert.ToInt32(pdms[0]);

            int d = Convert.ToInt32(pdms[1]);

            int m = Convert.ToInt32(pdms[2]);

            int s = Convert.ToInt32(pdms[3]);

            int answer = HowManyGames(p, d, m, s);

            Console.WriteLine(answer);
            Console.ReadKey();
        }

        private int HowManyGames(int p, int d, int m, int s)
        {
            int numberOfGames = 0;

            while (s >= p)
            {
                s -= p;
                numberOfGames += 1;
                if (p >= m)
                {
                    p -= d;
                    if (p < m)
                        p = m;
                }
            }

            return numberOfGames;
        }
    }
}
