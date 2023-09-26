using System;

namespace HackerRank.Solutions
{
    public class IntroToTutorialChallenges
    {
        internal void TakeInput()
        {
            int V = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int result = IntroTutorial(V, arr);

            Console.WriteLine(result);
            Console.ReadKey();

        }

        private int IntroTutorial(int v, int[] arr)
        {
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == v)
                {
                    index = i;
                    break;
                }
            }

            return index;            
        }
    }
}
