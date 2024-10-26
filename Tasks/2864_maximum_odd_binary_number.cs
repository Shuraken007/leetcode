using System.Collections.Specialized;
using System.Text;

namespace Leetcode;

public partial class Solution
{
   public string MaximumOddBinaryNumber(string s)
   {
      var st = new StringBuilder();

      int one_counter = 0;
      foreach (char c in s)
      {
         if (c == '1') one_counter++;
      }

      for (int i = 0; i < one_counter - 1; i++)
      {
         st.Append('1');
      }

      for (int i = 0; i < s.Length - one_counter; i++)
      {
         st.Append('0');
      }

      if (one_counter > 0) st.Append('1');

      return st.ToString();
   }

   public string MaximumOddBinaryNumberLinq(string s)
   {
      var ones = s.Count(c => c == '1');
      return new string(Enumerable.Repeat('1', ones - 1).Concat(Enumerable.Repeat('0', s.Length - ones)).Append('1').ToArray());
   }

}