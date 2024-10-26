using System.Text;

namespace Leetcode;

public partial class Solution
{

   public int FinalValueAfterOperations(string[] operations)
   {
      var i = 0;
      foreach (var o in operations)
         if (o[1] == '-') i--; else i++;

      return i;
   }
   public int FinalValueAfterOperationsLinq1(string[] operations) =>
      operations.Sum(s => s[1] == '-' ? -1 : +1);

   public int FinalValueAfterOperationsLinq2(string[] operations) =>
      operations.Aggregate(0, (acc, o) => o[1] == '-' ? acc - 1 : acc + 1);

   public int FinalValueAfterOperationsLinq3(string[] operations) =>
      operations.Select(s => s[1])
         .GroupBy(c => c)
         .Sum(g => g.Key == '+' ? g.Count() : -g.Count());

   public int FinalValueAfterOperationsLinq4(string[] operations) =>
      operations.Count(x => x.Contains("++")) - operations.Count(x => x.Contains("--"));

   public int FinalValueAfterOperationsLinq5(string[] operations)
       => 2 * operations.Count(o => o[1] == '+') - operations.Length;
}