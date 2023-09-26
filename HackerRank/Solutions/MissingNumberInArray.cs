using System;

namespace HackerRank.Solutions
{
    public class MissingNumberInArray
    {
        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), t => Convert.ToInt32(t));

            int _missingNumber = MissingNumber(array, n);

            Console.WriteLine(_missingNumber);
            Console.ReadKey();
        }

        private int MissingNumber(int[] array, int n)
        {
            #region Validations
            if (array == null)
                throw new ArgumentNullException("Array is null.", nameof(array));
            #endregion

            int sum = 0;

            for (int i = 0; i < n-1; i++)
            {
                sum += array[i];
            }
            return ((n * (n + 1)) / 2) - sum;
        }

    }
}
