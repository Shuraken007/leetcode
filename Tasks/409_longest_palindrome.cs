using System.Numerics;

namespace Leetcode;

public partial class Solution
{
   public int LongestPalindrome(string s)
   {
      Dictionary<char, int> hash = new();
      foreach (char c in s)
      {
         if (!hash.ContainsKey(c)) hash.Add(c, 0);
         hash[c]++;
      }
      bool is_center_filled = false;
      int l = 0;
      foreach (int count in hash.Values)
      {
         if (count % 2 == 0)
         {
            l += count;
            continue;
         }

         l += count / 2 * 2;
         if (!is_center_filled)
         {
            is_center_filled = true;
            l += 1;
         }
      }
      return l;
   }

   public int LongestPalindromeBits(string s)
   {
      UInt64 bitsForChar = 0;
      var longestPal = 0;
      var one = (UInt64)1;
      foreach (var letter in s)
      {
         UInt64 bit = one << (letter - 'A');
         if ((bit & bitsForChar) > 0)
         {
            longestPal += 2;
            bitsForChar ^= bit;
         }
         else
         {
            bitsForChar |= bit;
         }
      }
      if (bitsForChar > 0)
      {
         longestPal++;
      }
      return longestPal;
   }

   public int LongestPalindromeCodeGolf(string s)
   { // 89 characters
      long b = 0; foreach (var c in s) b ^= 1L << c; return s.Length - Math.Max(0, (int)long.PopCount(b) - 1);
   }

   public int LongestPalindromeIfOnBits(string s)
   {
      var map = new int[128];
      foreach (var c in s)
      {
         map[c]++;
      }
      int answer = 0, odd = 0;
      foreach (var v in map)
      {
         odd |= v & 1;
         answer += v & 0xFFFE;
      }
      return answer + odd;
   }

   public int LongestPalindromeGroupLinq(string s)
   {
      int longestPalindrome = 0;
      bool found = false;
      var g = s.GroupBy(x => x);
      foreach (var grp in g)
      {
         if (grp.Count() > 1 && grp.Count() % 2 == 0) { longestPalindrome += grp.Count(); }
         else if (grp.Count() > 1 && grp.Count() % 2 != 0)
         {
            longestPalindrome += grp.Count() - 1;
            longestPalindrome += found ? 0 : 1; found = true;
         }
         else if (grp.Count() == 1 && found == false) { found = true; longestPalindrome++; }
      }
      return longestPalindrome;
   }

   public int LongestPalindromeLinq1(string s) =>
       Math.Min(s.Length, 1 + s.GroupBy(c => c).Sum(g => g.Count() & ~1));

   public int LongestPalindromeLinq2(string s) =>
       BitOperations.PopCount(s.Aggregate(0ul, (a, c) => a ^ 1ul << c)) switch
       {
          0 => s.Length,
          var n => s.Length - n + 1,
       };

   public int LongestPalindromeLinq3(string s)
   {
      var answer = s.GroupBy(x => x);
      if (answer.Count() == 1)
      {
         return s.Length;
      }
      var diffChars = answer.Where(y => y.Count() % 2 == 1);
      var numOfOdds = diffChars.Count();
      var oneoff = numOfOdds > 0 ? 1 : 0;
      return s.Length - numOfOdds + oneoff;
   }
}