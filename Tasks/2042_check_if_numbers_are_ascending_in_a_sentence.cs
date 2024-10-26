namespace Leetcode;

public partial class Solution
{
   public bool AreNumbersAscending(string s)
   {
      string[] tokens = s.Split(' ');
      int last_num = -1;
      foreach (string token in tokens)
      {
         if (!int.TryParse(token, out int n)) continue;
         if (n <= last_num) return false;
         last_num = n;
      }
      return true;
   }

   public bool AreNumbersAscendingLinq1(string s, int p = 0) =>
       s.Split().All(w => !int.TryParse(w, out var n) || p < (p = n));

   public bool AreNumbersAscendingLinq2(string s)
    => s.Split().Where(x => int.TryParse(x, out _))
        .Select(int.Parse)
        .Aggregate((a, b) => a < b ? b : int.MaxValue) != int.MaxValue;
}