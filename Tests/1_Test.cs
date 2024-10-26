using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest {

   static object[] TwoSumCase = {
      new object[] { new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 } },
      new object[] { new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 } },
      new object[] { new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 } },
   };

   [TestCaseSource(nameof(TwoSumCase))]
   public void TwoSum(int[] nums, int target, int[] expected) {
      int[] result = this.solution.TwoSum(nums, target);
      Assert.That(result, Is.EqualTo(expected));
   }
}

