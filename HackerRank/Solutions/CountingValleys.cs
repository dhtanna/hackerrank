using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class CountingValleys
    {
        // https://www.hackerrank.com/challenges/counting-valleys/problem

        internal void TakeInput()
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = countingValleys(steps, path);

            Console.WriteLine(result);
        }

        private int countingValleys(int steps, string path)
        {
            int res = 0, currentPosition = 0; bool valueChnaged = false;

            for (int i = 0; i < steps; i++)
            {
                if(path[i] == 'U')
                {
                    if (!valueChnaged)
                        valueChnaged = true;
                    currentPosition++;
                }
                else
                {
                    if (!valueChnaged)
                        valueChnaged = true;
                    currentPosition--;
                }

                if(currentPosition == 0 && valueChnaged)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
