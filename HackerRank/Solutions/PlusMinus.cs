using System;

namespace HackerRank.Solutions
{
    public class PlusMinus
    {
        // https://www.hackerrank.com/challenges/plus-minus/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }

        private void plusMinus(int[] arr)
        {
            int plusSigns = 0, minusSigns = 0, zeros = 0, totalNumbers = arr.Length;

            for (int i = 0; i < totalNumbers; i++)
            {
                int currentNumber = arr[i];

                if (currentNumber > 0)
                {
                    plusSigns++;
                }
                else if (currentNumber < 0)
                {
                    minusSigns++;
                }
                else
                {
                    zeros++;
                }
            }

            Console.WriteLine(((decimal)plusSigns / totalNumbers).ToString("N6"));
            Console.WriteLine(((decimal)minusSigns / totalNumbers).ToString("N6"));
            Console.WriteLine(((decimal)zeros / totalNumbers).ToString("N6"));
            Console.ReadLine();
        }
    }
}
