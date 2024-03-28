using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class RomanToInt
    {
        // https://leetcode.com/problems/roman-to-integer/

        public void Execute()
        {
            var input = Console.ReadLine();

            var result = ConvertRomanToInt(input);

            Console.WriteLine(result);
        }

        private int ConvertRomanToInt(string s)
        {
            if (s.Length > 15)
            {
                return 0;
            }

            int result = 0, i = 0, lastIndex = s.Length-1;
            bool includedAfterChar = false;


            while (i < s.Length)
            {
                char current = s[i];
                includedAfterChar = false;

                if (i < lastIndex)
                {
                    char after = s[i + 1];

                    var substractedValue = SubstractValue(current, after);

                    if (substractedValue > 0)
                    {
                        result += substractedValue;
                        i += 2;
                        includedAfterChar = true;
                    }
                }
                
                if (includedAfterChar == false)
                {
                    var currentCharValue = GetIntValueFromRoman(current);

                    result += currentCharValue;
                    i += 1;
                }

                // MDCXCV
                // MCMXCIV
            }

            if (i < lastIndex)
            {
                result += GetIntValueFromRoman(s[lastIndex]);
            }
            return result;
        }

        private int GetIntValueFromRoman(char roman)
        {
            switch (roman)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
            }

            return 0;
        }

        private int SubstractValue(char current, char after)
        {
            int result = 0;

            if (current is 'I' && (after is 'V' || after is 'X'))
            {
                result = GetIntValueFromRoman(after) - GetIntValueFromRoman(current);
            }
            else if (current is 'X' && (after is 'L' || after is 'C'))
            {
                result = GetIntValueFromRoman(after) - GetIntValueFromRoman(current);
            }
            else if (current is 'C' && (after is 'D' || after is 'M'))
            {
                result = GetIntValueFromRoman(after) - GetIntValueFromRoman(current);
            }

            return result;
        }
    }
}
