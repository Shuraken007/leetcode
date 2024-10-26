namespace Leetcode;

public partial class Solution
{
   public bool BuddyStrings_HashSet(string s, string goal)
   {
      if (s == goal)
      {
         var set = new HashSet<char>();
         bool containsRepeated = s.Any(x => !set.Add(x));
         if (containsRepeated) { return true; }
         else return false;
      }
      if (s.Length != goal.Length) return false;
      var diff_idx = new List<int>();
      for (int i = 0; i < s.Length; i++)
      {
         if (s[i] != goal[i])
         {
            diff_idx.Add(i);
         }
      }
      if (diff_idx.Count != 2) return false;
      int diff1 = diff_idx[0], diff2 = diff_idx[1];
      if (s[diff1] != goal[diff2]) return false;
      if (s[diff2] != goal[diff1]) return false;
      return true;
   }

   record struct Diff(char X, char Y);

   public bool BuddyStrings_Record(string src, string goal)
   {
      if (src.Length != goal.Length) return false;

      bool isSwitchFound = false;
      Diff diff = default;
      int[] counts = new int[26];

      for (int i = 0; i < src.Length; i++)
      {
         char x = src[i];
         char y = goal[i];

         if (x == y) counts[x - 'a'] += 1;
         else if (isSwitchFound) return false;
         else if (diff == default) diff = new Diff(x, y);
         else if (diff.X == y && diff.Y == x) isSwitchFound = true;
         else return false;
      }
      // "a pair to switch is found" OR "equal strings with repeated chars" 
      return isSwitchFound || diff == default && counts.Any(x => x > 1);
   }
}