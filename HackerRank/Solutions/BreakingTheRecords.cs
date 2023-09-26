using System;
using System.Linq;

namespace HackerRank.Solutions
{
    public class BreakingTheRecords
    {
        //https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int[] result = BreakingRecords(scores);

            result.All(s => { Console.WriteLine(s); return true; });
            Console.ReadLine();
        }

        private int[] BreakingRecords(int[] scores)
        {
            int minScore = 0, maxScore = 0, minScoreCounter = 0, maxScoreCounter = 0;
            int[] result = new int[2];

            if (scores.Count() > 0)
            {
                minScore = scores[0];
                maxScore = scores[0];

                for (int i = 0; i < scores.Length; i++)
                {
                    int currentScore = scores[i];

                    if (currentScore > maxScore)
                    {
                        maxScore = currentScore;
                        maxScoreCounter++;
                        result[0] = maxScoreCounter;
                    }
                    else if (currentScore < minScore)
                    {
                        minScore = currentScore;
                        minScoreCounter++;
                        result[1] = minScoreCounter;
                    }
                }
            }
            else
            {
                result[0] = 0;
                result[1] = 0;
            }

            return result;
        }
    }
}
