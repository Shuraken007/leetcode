using System.Collections.Specialized;

namespace Leetcode;

public partial class Solution
{
   public int FirstUniqChar(string s)
   {
      var t = new Dictionary<char, int>();
      for (int i = 0; i < s.Length; i++)
      {
         char c = s[i];
         if (!t.ContainsKey(c)) t.Add(c, 0);
         t[c] += 1;
      }
      for (int i = 0; i < s.Length; i++)
      {
         char c = s[i];
         if (t[c] > 1) continue;
         return i;
      }
      return -1;
   }

   public int FirstUniqCharLinq(string s)
     => s.IndexOf(s.GroupBy(c => c).FirstOrDefault(g => g.Count() == 1)?.Key ?? char.MinValue);
}