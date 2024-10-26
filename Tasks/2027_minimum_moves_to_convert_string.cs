using System.Text;

namespace Leetcode;

public partial class Solution
{

   public int MinimumMoves(string s)
   {
      int counter = 0;
      int i = 0;
      while (i < s.Length)
      {
         if (s[i] != 'X') { i++; continue; }
         counter++;
         i += 3;
      }
      return counter;
   }

   public int MinimumMovesLinq1(string s) =>
      s.Aggregate((res: 0, skip: 0),
         (state, @char) =>
            state.skip > 0
               ? (state.res, --state.skip)
            : @char != 'X'
               ? (state.res, 0)
               : (++state.res, 3)
         , state => state.res
      );
}