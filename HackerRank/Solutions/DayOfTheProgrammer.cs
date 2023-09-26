using System;

namespace HackerRank.Solutions
{
    public class DayOfTheProgrammer
    {
        //https://www.hackerrank.com/challenges/day-of-the-programmer/problem
        internal void TakeInput()
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        private string dayOfProgrammer(int year)
        {
            if (year == 1918)
            {
                return "26.09.1918";
            }
            else if (IsLeapYear(year))
            {
                return "12.09." + year;
            }
            else
            {
                return "13.09." + year;
            }

        }

        private static bool IsLeapYear(int year)
        {
            if (year <= 1917)
            {
                if (year % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
