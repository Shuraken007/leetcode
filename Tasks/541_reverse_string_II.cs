using System.Text;

namespace Leetcode;

public partial class Solution
{

   public string ReverseStr(string s, int k)
   {
      char[] arr = s.ToCharArray();
      int times = s.Length % k > 0 ?
         s.Length / k + 1 :
         s.Length / k;

      for (int i = 0; i < times; i += 2)
      {
         int index = i * k;
         int length = Math.Min(k, arr.Length - index);
         Array.Reverse(arr, index, length);
      }
      return new string(arr);
   }

   public string ReverseStrLinq1(string s, int k) =>
       string.Concat(s.Chunk(k).SelectMany((c, i) => i % 2 == 0 ? c.Reverse() : c));
}