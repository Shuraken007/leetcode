namespace Leetcode;

public partial class Solution
{
   public void FillDiff(string s, int[] indexArr)
   {
      for (int i = 0; i < s.Length; i++)
      {
         char c = s[i];
         Console.WriteLine($"c: {c}, num: {c - 'a'}");
         indexArr[c - 'a'] = i;
      }
   }

   public int FindPermutationDifference(string s, string t)
   {
      int[] indexArr1 = new int['z' - 'a' + 1];
      int[] indexArr2 = new int['z' - 'a' + 1];
      FillDiff(s, indexArr1);
      FillDiff(t, indexArr2);

      int[] diff = indexArr1
         .Zip(indexArr2, (x, y) => Math.Abs(x - y))
         .ToArray<int>();
      return diff.Sum();
   }

   public int FindPermutationDifferenceLinq(string s, string t)
       => s.Select((c, i) => Math.Abs(i - t.IndexOf(c))).Sum();
}