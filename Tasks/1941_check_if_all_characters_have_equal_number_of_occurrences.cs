using System.Text;

namespace Leetcode;

public partial class Solution
{
   public bool AreOccurrencesEqualFreq(string s)
   {
      var freq = new int['z' - 'a' + 1];
      int last_counter = 0;
      foreach (char c in s)
      {
         freq[c - 'a']++;
         last_counter = freq[c - 'a'];
      }

      for (int i = 0; i < freq.Length; i++)
      {
         if (freq[i] == 0) continue;
         if (freq[i] != last_counter) return false;
      }
      return true;
   }

   public bool AreOccurrencesEqualDict(string s)
   {
      Dictionary<char, int> dict = new();
      int last_counter = 0;
      foreach (char c in s)
      {
         dict.TryAdd(c, 0);
         dict[c]++;
         last_counter = dict[c];
      }

      foreach (int count in dict.Values)
         if (count != last_counter) return false;
      return true;
   }

   public bool AreOccurrencesEqualLinq(string s) =>
      s.GroupBy(c => c).Select(c => c.Count()).Distinct().Count() == 1;
}