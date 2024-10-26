using System.Collections.Specialized;
using System.Text;

namespace Leetcode;

public partial class Solution
{
   public int MinimumChairs(string s)
   {
      int i = 0;
      int max_i = 0;
      foreach (char c in s)
      {
         switch (c)
         {
            case 'E':
               i++;
               break;
            case 'L':
               i--;
               break;
         }
         max_i = Math.Max(i, max_i);
      }
      return max_i;
   }

}