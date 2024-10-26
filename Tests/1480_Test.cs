using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] RunningSumCase =
   {
      new object[] { new int[] { 1, 2, 3, 4}, new int[] { 1, 3, 6, 10 } },
      new object[] { new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 } },
      new object[] { new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 } },
   };

   [TestCaseSource(nameof(RunningSumCase))]
   public void RunningSum(int[] input, int[] expected)
   {
      var result = this.solution.RunningSum(input);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(RunningSumCase))]
   public void RunningSumLinq1(int[] input, int[] expected)
   {
      var result = this.solution.RunningSumLinq1(input);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(RunningSumCase))]
   public void RunningSumLinq2(int[] input, int[] expected)
   {
      var result = this.solution.RunningSumLinq2(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

