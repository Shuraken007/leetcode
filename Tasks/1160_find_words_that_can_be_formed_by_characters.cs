using System.Text;

namespace Leetcode;

public partial class Solution
{

   public int CountCharacters(string[] words, string chars)
   {
      int good_sum = 0;
      int[] freq = new int['z' - 'a' + 1];
      foreach (char c in chars) freq[c - 'a']++;

      foreach (string word in words)
      {
         int[] tmp_freq = new int[freq.Length];
         freq.CopyTo(tmp_freq, 0);

         bool word_passed = true;
         foreach (char c in word)
         {
            tmp_freq[c - 'a']--;
            if (tmp_freq[c - 'a'] < 0)
            {
               word_passed = false;
               break;
            }
         }
         if (word_passed) good_sum += word.Length;
      }
      return good_sum;
   }

   public int CountCharactersLinq(string[] words, string chars)
      => words.Where(w => w.All(
         c => chars.Count(x => x == c) >= w.Count(x => x == c)
      )).Sum(w => w.Length);
}