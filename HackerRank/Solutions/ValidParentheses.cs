using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class ValidParentheses
    {
        // https://leetcode.com/problems/valid-parentheses/description/
        public void Execute()
        {
            string s = Console.ReadLine();

            bool valid = IsValid(s);

            Console.WriteLine(valid);
        }

        private bool IsValid(string s)
        {
            Stack<char> parenthesesStack = new Stack<char>();

            for (int i = 0; i < s.Length;  i++)
            {
                var currentParentheses = s[i];

                if (currentParentheses is '(' || currentParentheses is '{' || currentParentheses is '[')
                {
                    parenthesesStack.Push(currentParentheses);
                }
                else if (parenthesesStack.Count == 0)
                    return false;
                else if (currentParentheses is ')')
                {
                    char poppedParentheses = parenthesesStack.Pop();

                    if (poppedParentheses is '(') continue;

                    else return false;
                }
                else if (currentParentheses  is '}')
                {
                    char poppedParenthenses = parenthesesStack.Pop();

                    if (poppedParenthenses is '{') continue;
                    else return false;
                }
                else if (currentParentheses is ']')
                {
                    char poppedParenthenses = parenthesesStack.Pop();

                    if (poppedParenthenses is '[') continue;
                    else return false;
                }
            }

            return parenthesesStack.Count == 0;


        }

        private bool CheckValidParentheses(string s)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                var currentParentheses = s[i];

                if (currentParentheses is '(' || currentParentheses is '{' || currentParentheses is '[')
                {
                    if (result.ContainsKey(currentParentheses))
                        result[currentParentheses] = result[currentParentheses] + 1;
                    else result.Add(currentParentheses, 1);
                }
                else if (currentParentheses is ')')
                {
                    if (result.ContainsKey('('))
                    {
                        result['('] = result['('] - 1;
                    }
                    else return false;
                }
                else if (currentParentheses is '}')
                {
                    if (result.ContainsKey('{'))
                    {
                        result['{'] = result['{'] - 1;
                    }
                    else return false;
                }
                else if (currentParentheses is ']')
                {
                    if (result.ContainsKey('['))
                    {
                        result['['] = result['['] - 1;
                    }
                    else return false;
                }
            }

            for (int i = 0; i < result.Keys.Count; i++)
            {
                var parenthesisIterator = result.ElementAt(i);

                if (parenthesisIterator.Value > 0)
                    return false;
            }

            return true;
        }
    }
}
