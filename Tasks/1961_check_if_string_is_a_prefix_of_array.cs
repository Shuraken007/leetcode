using System.Text;

namespace Leetcode;

public partial class Solution
{
   public bool IsPrefixString(string s, string[] words)
   {
      int l = 0;
      int words_amount = 0;
      foreach (string str in words)
      {
         l += str.Length;
         words_amount++;
         if (l >= s.Length) break;
      }
      if (l != s.Length) return false;

      int i = 0;
      foreach (char c in words.Take(words_amount).SelectMany(s => s))
      {
         if (s[i] != c) return false;
         i++;
      }

      return true;
   }
}