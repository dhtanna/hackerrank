using System;
using System.Linq;

namespace HackerRank.Solutions
{
    public class CutTheSticks
    {
        // https://www.hackerrank.com/challenges/cut-the-sticks/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] result = cutTheSticks(arr);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadLine();

        }

        private int[] cutTheSticks(int[] arr)
        {
            int[] result = new int[arr.Length + 1];

            result[0] = arr.Length;
            int i = 1;

            do
            {
                int min = arr.Min();

                arr = arr.Select(s => s - min).Where(s => s != 0).ToArray();

                result[i++] = arr.Length;

            } while (arr.Length != 0);

            return result.Where(s => s != 0).ToArray();
        }
    }
}
