using System;

namespace HackerRank.Solutions
{
    public class ViralAdvertising
    {
        // https://www.hackerrank.com/challenges/strange-advertising/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int viralAdvertising(int n)
        {
            int result = 0, adSharedWithPeople = 5;

            for (int i = 0; i < n; i++)
            {
                int adLikeByPeople = adSharedWithPeople / 2;

                adSharedWithPeople = adLikeByPeople * 3;

                result += adLikeByPeople;
            }

            return result;
        }
    }
}
