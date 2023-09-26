using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class CatsAndMouse
    {
        //https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
        internal void TakeInput()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
                Console.ReadLine();
            }
        }

        private string catAndMouse(int x, int y, int z)
        {
            string catA = "Cat A", catB = "Cat B", mouse = "Mouse C";
            int differenceForCatA = Math.Abs(x - z), differenceForCatB = Math.Abs(y - z);

            if (differenceForCatA > differenceForCatB)
            {
                return catB;
            }
            else if(differenceForCatB > differenceForCatA)
            {
                return catA;
            }
            else
            {
                return mouse;
            }
        }
    }
}
