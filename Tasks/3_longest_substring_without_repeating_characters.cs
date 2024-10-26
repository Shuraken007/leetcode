namespace Leetcode;

public partial class Solution
{
   public int LengthOfLongestSubstring3(string s)
   {
      int maxL = 0;
      int i = 0, j = 0;

      Dictionary<char, int> hash = new();
      for (j = i; j < s.Length; j++)
      {
         char c = s[j];
         if (hash.ContainsKey(c))
         {
            maxL = Math.Max(maxL, j - i);
            i = hash[c] + 1;
            foreach ((char key, int index) in hash)
               if (index < i) hash.Remove(key);
         }
         hash.Add(c, j);
      }

      maxL = Math.Max(maxL, j - i);
      return maxL;
   }
}