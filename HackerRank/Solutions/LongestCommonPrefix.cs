using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class LongestCommonPrefix
    {
        // https://leetcode.com/problems/longest-common-prefix/

        public void Execute()
        {
            var input = Console.ReadLine();

            string output = FindLongestCommonPrefix(input.Split(','));

            Console.WriteLine(output);
        }

        private string FindLongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;

            string shortestString;
            int shortestStringIndex;

            (shortestString, shortestStringIndex) = GetShortestString(strs);

            for (int i = 0; i < shortestString.Length; i++)
            {
                char charToCheck = shortestString[i];

                bool allMatched = CompareChar(strs, charToCheck, i, shortestStringIndex);

                if (allMatched)
                {
                    result += charToCheck;
                }
                else break;
            }

            return result;
        }

        private bool CompareChar(string[] strs, char charToCheck, int index, int ignoreIndex)
        {
            bool allMatched = true;

            for (int i = 0; i < strs.Length; i++)
            {
                if (i != ignoreIndex)
                {
                    var currentStringChar = strs[i][index];

                    if (currentStringChar != charToCheck)
                    {
                        allMatched = false;
                        break;
                    }
                }
            }

            return allMatched;
        }

        private (string, int) GetShortestString(string[] strs)
        {
            string shortestString = strs[0];
            int shortestStringIndex = 0;

            for (int i = 1; i < strs.Length; i++)
            {
                string currentString = strs[i];

                if (currentString.Length < shortestString.Length)
                {
                    shortestString = currentString;
                    shortestStringIndex = i;
                }

            }
            return (shortestString, shortestStringIndex);
        }
    }
}
