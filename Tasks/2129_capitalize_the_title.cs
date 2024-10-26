using System.Text;

namespace Leetcode;

public partial class Solution
{
   public bool IsWordShort(char[] arr, int i)
   {
      if (i + 2 >= arr.Length) return true;
      if (arr[i + 1] == ' ') return true;
      if (arr[i + 2] == ' ') return true;
      return false;
   }

   public string CapitalizeTitle(string title)
   {
      char case_diff = (char)('a' - 'A');
      char[] arr = title.ToCharArray();
      char prev = ' ';
      for (int i = 0; i < arr.Length; i++)
      {
         char c = arr[i];
         bool is_word_start = prev == ' ';
         bool is_word_short = is_word_start && IsWordShort(arr, i);
         if (is_word_start && is_word_short && char.IsUpper(c))
            arr[i] -= case_diff;
         else if (is_word_start && !is_word_short && char.IsLower(c))
            arr[i] += case_diff;
         else if (!is_word_start && char.IsUpper(c))
            arr[i] -= case_diff;

         prev = c;
      }
      return new string(arr);
   }
}