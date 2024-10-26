using System.Text;

namespace Leetcode;

public partial class Solution
{
   public string ConvertDateToBinary(string date) =>
      date.Split('-')
         .Select(c => int.Parse(c))
         .Select(num => Convert.ToString(num, 2))
         .Aggregate(new StringBuilder(), (b, s) =>
            b.Append(b.Length == 0 ? "" : '-').Append(s)
         ).ToString();
}