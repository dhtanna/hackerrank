using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class FindDigits
    {
        //https://www.hackerrank.com/challenges/find-digits/problem?h_r=next-challenge&h_v=zen

        internal void TakeInput()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        private int findDigits(int n)
        {
            int[] digitsOfN = SplitNumber(n);
            int counter = 0;

            for (int i = 0; i < digitsOfN.Length; i++)
            {
                if (digitsOfN[i] != 0 && n % digitsOfN[i] == 0)
                {
                    counter++;
                }
            }

            return counter;

        }

        private int[] SplitNumber(int n)
        {
            int[] result = new int[n.ToString().Length];
            int i = 0;

            while (n > 0)
            {
                result[i] = n % 10;
                n = n / 10;
                i++;
            }

            return result;
        }
    }
}
