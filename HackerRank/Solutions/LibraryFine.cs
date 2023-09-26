using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class LibraryFine
    {
        // https://www.hackerrank.com/challenges/library-fine/problem?h_r=next-challenge&h_v=zen

        internal void TakeInput()
        {
            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);

            int m1 = Convert.ToInt32(d1M1Y1[1]);

            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);

            int m2 = Convert.ToInt32(d2M2Y2[1]);

            int y2 = Convert.ToInt32(d2M2Y2[2]);

            int result = libraryFine(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            if (d2 >= d1 && y2 == y1 && m2 == m1)
            {
                return 0;
            }
            else if((m1 == m2) && (y1 == y2) && (d1 > d2))
            {
                return 15 * (d1 - d2);
            }
            else if(m1 > m2 && y2 == y1)
            {
                return 500 * (m1 - m2);
            }
            else if(y1 > y2)
            {
                return 10000;
            }
            return 0;
        }
    }
}
