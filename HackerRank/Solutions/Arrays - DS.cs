using System;

namespace HackerRank.Solutions
{
    public class Arrays___DS
    {
        // https://www.hackerrank.com/challenges/arrays-ds/problem
        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int[] res = reverseArray(ar);

            Console.WriteLine(string.Join(" ", res));
            Console.ReadLine();
        }

        private int[] reverseArray(int[] arr)
        {
            int[] res = new int[arr.Length];
            if(arr.Length > 0)
            {
                int x = 0;
                for (int i = arr.Length; i > 0; i--)
                {
                    res[x++] = arr[i-1];
                }
            }
            return res;
        }
    }
}
