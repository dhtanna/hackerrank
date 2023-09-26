using System;

namespace HackerRank.Solutions
{
    public class AngryProfessor
    {
        //https://www.hackerrank.com/challenges/angry-professor/problem

        internal void TakeInput()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

                string result = angryProfessor(k, a);

                Console.WriteLine(result);
            }
        }

        private string angryProfessor(int k, int[] a)
        {
            string yes = "YES", no = "NO";
            int diciplinedStudents = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                {
                    diciplinedStudents++;
                }
            }

            if (diciplinedStudents < k)
            {
                return yes;
            }
            return no;
        }
    }
}
