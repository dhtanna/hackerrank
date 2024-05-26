using System;

namespace HackerRank.Solutions
{
    public class SumOfSeries
    {
        // https://www.geeksforgeeks.org/problems/sum-of-series2811/1?page=1&difficulty=School&sortBy=submissions

        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(seriesSum(n));
        }

        public long seriesSum(int n)
        {
            long sum = 0;
            int i = n, j = 0;

            while (j < i)
            {
                sum = sum + j + i;
                j++;
                i--;
            }

            if (n % 2 == 0)
            {
                sum += i;
            }

            return sum;
        }
    }
}
