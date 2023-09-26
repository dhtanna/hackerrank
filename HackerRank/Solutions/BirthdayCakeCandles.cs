using System;

namespace HackerRank.Solutions
{
    public class BirthdayCakeCandles
    {
        //https://www.hackerrank.com/challenges/birthday-cake-candles/problem

        internal void TakeInput()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int birthdayCakeCandles(int[] ar)
        {
            int maxValue = ar[0], counter = 1;

            if (maxValue > 0 && counter > 0)
            {
                for (int i = 1; i < ar.Length; i++)
                {
                    int currentValue = ar[i];
                    if (currentValue == maxValue)
                    {
                        counter++;
                    }
                    else if (currentValue > maxValue)
                    {
                        maxValue = currentValue;
                        counter = 1;
                    }
                }
            }
            return counter;
        }
    }
}
