using System.Collections.Specialized;
using System.Text;

namespace Leetcode;

public partial class Solution
{
   public string LongestCommonPrefix(string[] strs)
   {
      StringBuilder st = new();
      int j = 0;
      while (true)
      {
         char c = default;
         for (int i = 0; i < strs.Length; i++)
         {
            string s = strs[i];
            if (s.Length <= j) goto stop;
            if (i == 0) c = s[j];
            if (s[j] != c) goto stop;
         }
         st.Append(c);
         j++;
      }
   stop:;
      return st.ToString();
   }

   public string LongestCommonPrefixLinq(string[] strs)
   {
      if (!strs.Any())
         return string.Empty;

      string shortestWord = strs.MinBy(a => a.Length) ?? "";
      for (var i = shortestWord.Length; i > 0; i--)
      {
         if (strs.All(a => a.StartsWith(shortestWord[..i])))
            return shortestWord[..i];
      }

      return string.Empty;
   }

   public string LongestCommonPrefixLinq1(string[] ss)
   {
      string shortest = ss.OrderBy(s => s.Length).First();

      for (int i = 0; i < shortest.Length; i++)
      {
         if (ss.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];
      }

      return shortest;
   }

   public string LongestCommonPrefixLinq2(string[] ss)
   {
      int i = 0;
      StringBuilder sb = new();
      string shortest = ss.OrderBy(s => s.Length).First();

      foreach (char c in shortest)
      {
         if (ss.Any(s => s[i] != c)) break;
         sb.Append(c);
         i++;
      }

      return sb.ToString();
   }

   public string LongestCommonPrefixLinq3(string[] ss)
   {
      StringBuilder sb = new();
      string shortest = ss.OrderBy(s => s.Length).First();

      foreach (var (c, i) in shortest.Select((c, i) => (c, i)))
      {
         if (ss.Any(s => s[i] != c)) break;
         sb.Append(c);
      }

      return sb.ToString();
   }
}