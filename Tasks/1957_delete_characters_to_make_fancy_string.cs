using System.Text;

namespace Leetcode;

public partial class Solution
{
   public string MakeFancyString(string s)
   {
      var sb = new StringBuilder().Append(s[0]);
      char prev = s[0];
      int counter = 1;
      foreach (char c in s.Skip(1))
      {
         if (c == prev && counter == 2) continue;
         sb.Append(c);
         if (c != prev)
         {
            prev = c;
            counter = 1;
         }
         else counter++;
      }
      return sb.ToString();
   }
}