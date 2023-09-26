using System;

namespace HackerRank.Solutions
{
    public class SimpleArraySum
    {
        //https://www.hackerrank.com/challenges/simple-array-sum/problem

        public void TakeInput()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
