using System;

namespace HackerRank.Solutions
{
    public class BeautifulTriplets
    {
        //https://www.hackerrank.com/challenges/beautiful-triplets/problem

        internal void TakeInput()
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int result = BeautifulTripletsFn(d, arr);

            Console.WriteLine(result);
        }

        private int BeautifulTripletsFn(int d, int[] arr)
        {
            #region Validation
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));
            if (arr.Length == 0)
                throw new ArgumentException("Values are required", nameof(arr));
            #endregion

            int count = 0, n = arr.Length; 

            for (int i = 0; i < n - 2; i++)
            {
                int first = arr[i];
                bool match = false;
                for (int j = i + 1; j < n - 1; j++)
                {
                    int second = arr[j];

                    if((second - first) == d)
                    {
                        for (int k = j + 1; k < n; k++)
                        {
                            int third = arr[k];

                            if((third - second) == d)
                            {
                                count += 1;
                                match = true;
                                break;
                            }
                        }
                    }

                    if (match)
                        break;
                }
            }

            return count;
        }
    }
}
