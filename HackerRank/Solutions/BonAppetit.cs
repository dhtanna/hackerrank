using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions
{
    public class BonAppetit
    {
        // https://www.hackerrank.com/challenges/bon-appetit/problem

        internal void TakeInput()
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
            Console.ReadLine();
        }

        private void bonAppetit(List<int> bill, int k, int b)
        {
            string bonAppetit = "Bon Appetit";
            int sum = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                {
                    sum += bill[i];
                }
            }

            int annaShare = sum / 2;

            if (b == annaShare)
            {
                Console.WriteLine(bonAppetit);
            }
            else
            {
                Console.WriteLine(b - annaShare);
            }
        }
    }
}
