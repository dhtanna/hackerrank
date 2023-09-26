using System;

namespace HackerRank.Solutions
{
    public class SuperReducedString
    {
        //https://www.hackerrank.com/challenges/reduced-string/problem
        internal void TakeInput()
        {
            string s = Console.ReadLine();

            string result = SuperReducedStringfn(s);

            Console.WriteLine(result);
            Console.ReadKey();
            
        }

        private string SuperReducedStringfn(string s)
        {
            bool reduced;
            do
            {
                reduced = false;

                for (int i = 0; i < s.Length - 1;)
                {
                    if (s[i] == s[i + 1])
                    {
                        s = s.Substring(0, i) + s.Substring(i + 2);
                        reduced = true;
                    }
                    else
                        ++i;
                }
            } while (reduced);

            return string.IsNullOrEmpty(s) ? "Empty String" : s;
        }        
    }
}
