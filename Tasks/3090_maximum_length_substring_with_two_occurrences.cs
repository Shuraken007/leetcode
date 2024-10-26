namespace Leetcode;

public partial class Solution
{
   public int MaximumLengthSubstring(string s)
   {
      int max_length = 0;
      int pos = 0;
      int[] first_idx = new int['z' - 'a' + 1];

      while (pos < s.Length)
      {
         int length = 0;
         int[] freq = new int['z' - 'a' + 1];
         for (int i = pos; i < s.Length; i++)
         {
            int num = s[i] - 'a';
            freq[num]++;
            if (freq[num] == 1) first_idx[num] = i;
            if (freq[num] > 2)
            {
               pos = first_idx[num] + 1;
               break;
            }
            length = i - pos + 1;
         }
         max_length = Math.Max(max_length, length);
         if (pos + length == s.Length) break;
         if (s.Length - pos <= max_length) break;
      }
      return max_length;
   }

   public int MaximumLengthSubstringLinq1(string s)
   {
      return Enumerable.Range(0, s.Length).
             SelectMany(x => Enumerable.Range(1, s.Length - x).Select(y => s.Substring(x, y))).
             Where(x => x.GroupBy(g => g).Select(g => g.Count()).Max() <= 2).
             Select(x => x.Length).Max();
   }
}