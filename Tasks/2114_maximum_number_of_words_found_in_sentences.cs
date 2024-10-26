using System.Text;

namespace Leetcode;

public partial class Solution
{
   public int MostWordsFound(string[] sentences)
   {
      int max = 0;
      foreach (string s in sentences)
      {
         int words = 1;
         foreach (char c in s)
            if (c == ' ') words++;
         max = Math.Max(words, max);
      }
      return max;
   }

   public int MostWordsFoundLinq(string[] sentences) =>
      sentences.Max(s => s.Where(c => c == ' ').Count() + 1);
}