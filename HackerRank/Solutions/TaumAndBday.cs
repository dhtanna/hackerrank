using System;
using System.Numerics;

namespace HackerRank.Solutions
{
    public class TaumAndBday
    {
        // https://www.hackerrank.com/challenges/taum-and-bday/problem

        internal void TakeInput()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int b = Convert.ToInt32(firstMultipleInput[0]);

                int w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int bc = Convert.ToInt32(secondMultipleInput[0]);

                int wc = Convert.ToInt32(secondMultipleInput[1]);

                int z = Convert.ToInt32(secondMultipleInput[2]);

                long result = TaumBday(b, w, bc, wc, z);

                Console.WriteLine(result);
                Console.ReadKey();
            }
        }

        private long TaumBday(int b, int w, int bc, int wc, int z)
        {
            if (bc > (wc + z))
                return (b * (wc + z)) + (wc * w);
            else if (wc > (bc + z))
                return (w * (bc + z)) + (bc * b);
            else
                return (b * bc) + (w * wc);
        }
    }
}
