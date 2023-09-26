using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class DesignerPDFViewer
    {
        //https://www.hackerrank.com/challenges/designer-pdf-viewer/problem?h_r=next-challenge&h_v=zen

        internal void TakeInput()
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
            Console.ReadLine();        }

        private int designerPdfViewer(int[] h, string word)
        {
            var alphabates = Enumerable.Range('a', 'z'- 'a' + 1).Select(s => (char)s).ToList();
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            for (int i = 0; i < h.Length; i++)
            {
                pairs.Add(alphabates[i], h[i]);
            }

            int maxValueCounter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentCharacter = word[i];
                int height = pairs[currentCharacter];
                if (height > maxValueCounter)
                {
                    maxValueCounter = height;
                }
            }
            return maxValueCounter * word.Length;
        }
    }
}
