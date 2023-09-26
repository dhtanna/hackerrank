using System;

namespace HackerRank.Solutions
{
    public class ElectronicsShop
    {
        // https://www.hackerrank.com/challenges/electronics-shop/problem
        internal void TakeInput()
        {
            string[] bnm = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }

        private int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int res = -1;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int sumOfTwoItems = keyboards[i] + drives[j];

                    if (sumOfTwoItems <= b && sumOfTwoItems > res)
                    {
                        res = sumOfTwoItems;
                    }
                }
            }
            return res;
        }
    }
}
