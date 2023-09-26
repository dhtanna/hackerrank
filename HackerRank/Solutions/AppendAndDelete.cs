using System;
using System.Linq;

namespace HackerRank.Solutions
{
    public class AppendAndDelete
    {
        //https://www.hackerrank.com/challenges/append-and-delete/problem?h_r=next-challenge&h_v=zen

        internal void TakeInput()
        {
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private string appendAndDelete(string s, string t, int k)
        {
            while (t.IndexOf(s) != 0 && k > 0)
            {
                s = s.Remove(s.Length - 1, 1);
                k--;
            }

            if (s.ToCharArray().All(x => t.ToCharArray().All(y => y == x)))
            {
                return "Yes";
            }
            else if (s == t)
            {
                return "Yes";
            }
            else if (s.Length == 0 && k >= t.Length)
            {
                return "Yes";
            }
            else if ((t.Length - s.Length) >= k)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }


        private static string OneLogic(string s, string t, int k)
        {
            char[] firstInput = s.ToCharArray();
            char[] secondInput = t.ToCharArray();
            bool secondStringNotExists = s.IndexOf(t) == -1;
            if (secondStringNotExists)
            {
                return "No";
            }
            else if (s == t)
            {
                return "Yes";
            }

            char[] firstStringUniqueChars = GetFirstStringUniqueChars(s, t, firstInput, secondInput);

            if (firstStringUniqueChars.Length > k)
            {
                return "No";
            }

            char[] secondStringUniqueChars = GetFirstStringUniqueChars(s, t, secondInput, firstInput);

            return string.Empty;
        }

        private static char[] GetFirstStringUniqueChars(string s, string t, char[] firstInput, char[] secondInput)
        {
            char[] firstUnique = new char[Math.Abs(firstInput.Length - secondInput.Length)];
            int startingIndex = 0;
            int position = s.IndexOf(t);

            if (position == 0)
            {
                for (int i = 0; i < firstInput.Length; i++)
                {
                    try
                    {
                        if (firstInput[i] != secondInput[i])
                        {
                            firstUnique[startingIndex++] = firstInput[i];
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        firstUnique[startingIndex++] = firstInput[i];
                    }
                }
            }
            else
            {
                for (int i = position - 1; i >= 0; i--)
                {
                    firstUnique[i] = firstInput[i];
                }
            }

            return firstUnique;
        }
    }
}
