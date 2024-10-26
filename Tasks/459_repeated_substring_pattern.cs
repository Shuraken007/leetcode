namespace Leetcode;

public partial class Solution
{
   public bool IsSubstrRepeated(string s, string subs)
   {
      for (int i = 0; i < s.Length; i++)
      {
         if (s[i] != subs[i % subs.Length]) return false;
      }
      return true;
   }

   public bool RepeatedSubstringPattern(string s)
   {
      for (int i = 0; i < s.Length / 2; i++)
      {
         if (s.Length % (i + 1) > 0) continue;
         string subs = s.Substring(0, i + 1);
         if (IsSubstrRepeated(s, subs)) return true;
      }
      return false;
   }
}