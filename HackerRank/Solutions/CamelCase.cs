using System;

namespace HackerRank.Solutions
{
    public class CamelCase
    {
        //https://www.hackerrank.com/challenges/camelcase/problem

        internal void TakeInput()
        {
            string s = Console.ReadLine();

            int result = camelcase(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int camelcase(string s)
        {
            int wordCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int charCode = (int)s[i];

                if (charCode >= 65 && charCode <= 90)
                {
                    wordCount++;
                }

            }
            return wordCount + 1;
        }
    }
}
