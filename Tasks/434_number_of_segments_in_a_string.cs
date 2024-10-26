using Re = System.Text.RegularExpressions.Regex;

namespace Leetcode;

public partial class Solution
{
   public int CountSegmentsSplitOptions(string s) =>
      s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

   public int CountSegmentsRe(string s) =>
      string.IsNullOrWhiteSpace(s)
         ? 0
         : Re.Split(s.Trim(), @" {1,}").Count();
}