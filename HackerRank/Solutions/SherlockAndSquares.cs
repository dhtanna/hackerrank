using System;

namespace HackerRank.Solutions
{
    public class SherlockAndSquares
    {
        //https://www.hackerrank.com/challenges/sherlock-and-squares/problem

        internal void TakeInput()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        private int squares(int a, int b)
        {
            int result = 0, temp = 0,  i = a;

            do
            {
                temp = (int)Math.Sqrt(i);

                if ((temp * temp) == i)
                {
                    result++;
                    break;
                }

                i++;
                if (i >= b)
                {
                    break;
                }

            } while (true);

            if (temp > 0)
            {
                for (int j = temp + 1; j <= b; j++)
                {
                    var square = j * j;

                    if (square > b)
                    {
                        break;
                    }
                    result++;
                }
            }

            return result;
        }        
    }
}
