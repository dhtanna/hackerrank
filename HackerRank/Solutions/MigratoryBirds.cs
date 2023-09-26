using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions
{
    public class MigratoryBirds
    {
        //https://www.hackerrank.com/challenges/migratory-birds/problem

        internal void TakeInput()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < arr.Count; i++)
            {
                int value = arr[i];
                if (pairs.ContainsKey(value))
                {
                    pairs[value]++;
                }
                else
                {
                    pairs.Add(value, 1);
                }
            }

            int maxValue = pairs.Values.Max();

            return (from t in pairs
                    where t.Value == maxValue
                    orderby t.Key
                    select t.Key).FirstOrDefault();
        }
    }
}
