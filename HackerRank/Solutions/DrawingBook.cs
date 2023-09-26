using System;

namespace HackerRank.Solutions
{
    public class DrawingBook
    {
        // pending
        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());

            int result = PageCount(n, p);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int PageCount(int n, int p)
        {
            int result = 0;

            bool fromStart = (p - 1) < (n - p);

            if (p == 1)
                return 0;

            if (fromStart)
            {
                float temp = (float)(n - p) / 2;

                if (temp > 0 && temp < 1)
                    result = 1;
                else
                    result = Convert.ToInt32(Math.Ceiling(temp)) - 1;
            }
            else
            {
                if((n % 2) == 0)
                {

                }
                float temp = (float)(n - p) / 2;

                if (temp > 0 && temp < 1)
                    result = 1;
                else
                    result = Convert.ToInt32(Math.Ceiling(temp));
            }

            //n = 5 p=2

            return result;
        }
    }
}
