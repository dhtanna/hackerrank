using System;
using System.Numerics;

namespace HackerRank.Solutions
{
    public class ExtraLongFactorials
    {
        //https://www.hackerrank.com/challenges/extra-long-factorials/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            extraLongFactorials(n);
        }

        private void extraLongFactorials(int n)
        {
            BigInteger result = n;

            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = n - 1; i > 0; i--)
                {
                    result *= i;
                }

                Console.WriteLine(result);
            }
            
            Console.ReadLine();
        }
    }
}
