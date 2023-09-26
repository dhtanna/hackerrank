using System;
using System.Linq;

namespace HackerRank.Solutions
{
    public class RepeatedString
    {
        // https://www.hackerrank.com/challenges/repeated-string/problem

        internal void TakeInput()
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private long repeatedString(string s, long n)
        {
            var inSingle = s.Count(x => x == 'a');

            var full = n / s.Length;

            var rest = n % s.Length;

            var inRest = s.Substring(0, (int)rest).Count(x => x == 'a');

            var result = (inSingle * full) + inRest;

            return result;

        }
    }
}
