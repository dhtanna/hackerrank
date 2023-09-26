using System;

namespace HackerRank.Solutions
{
    public class CatsAndAMouse
    {

        // https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
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
            }

        }

        private string catAndMouse(int x, int y, int z)
        {
            string CatA = "Cat A", catB = "Cat B", mouseC = "Mouse C";

            int diffFromZtoY = Math.Abs(y - z);
            int diffFromZtoX = Math.Abs(x - z);

            if (diffFromZtoX > diffFromZtoY)
                return catB;
            else if (diffFromZtoY > diffFromZtoX)
                return CatA;
            else
                return mouseC;
        }
    }
}
