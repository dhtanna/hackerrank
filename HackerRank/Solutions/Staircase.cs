using System;

namespace HackerRank.Solutions
{
    public class Staircase
    {
        //https://www.hackerrank.com/challenges/staircase/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }

        private void staircase(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                if (i != n && i != 0)
                {
                    Console.WriteLine(); 
                }
            }
            Console.ReadLine();
        }
    }
}
