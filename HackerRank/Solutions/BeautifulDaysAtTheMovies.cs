using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class BeautifulDaysAtTheMovies
    {
        //https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem

        internal void TakeInput()
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = BeautifulDays(i, j, k);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int BeautifulDays(int i, int j, int k)
        {
            int result = 0;

            for (int startingIndex = i; startingIndex <= j; startingIndex++)
            {
                int reversNumber = ReverseNumber(startingIndex);

                bool isBeautifulDay = Math.Abs(startingIndex - reversNumber) % k == 0;

                if (isBeautifulDay)
                {
                    result++;
                }
            }

            return result;
        }

        private int ReverseNumber(int n)
        {
            int reverse = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }

            return reverse;
        }
    }
}
