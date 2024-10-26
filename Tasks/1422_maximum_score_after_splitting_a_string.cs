namespace Leetcode;

public partial class Solution
{
   public int MaxScore(string s)
   {
      int cur_ones = s.Count(c => c == '1');
      int max_score = 0, cur_zeros = 0;
      for (int i = 0; i < s.Length - 1; i++)
      {
         if (s[i] == '0') cur_zeros++;
         else cur_ones--;
         int score = cur_zeros + cur_ones;
         max_score = Math.Max(max_score, score);
      }
      return max_score;
   }

   public int MaxScoreLinq1(string s) =>
      s.Skip(1).Aggregate<char, (int min, int d), int>(
         (int.MaxValue, 2 * s[0] - 97), (t, c)
         => (t.d < t.min ? t.d : t.min, t.d + 2 * c - 97),
            t => (t.d + s.Length) / 2 - t.min
         );

   public int MaxScoreLinq2(string s) => s.SkipLast(1).Aggregate(
       (Result: 0, Zeros: 0, Ones: s.Count(c => c == '1')),
       (t, c) =>
         c == '0' ?
            (Math.Max(t.Result, t.Zeros + t.Ones + 1), t.Zeros + 1, t.Ones) :
            (Math.Max(t.Result, t.Zeros + t.Ones - 1), t.Zeros, t.Ones - 1),
       t => t.Result);

}