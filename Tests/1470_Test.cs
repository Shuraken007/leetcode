using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] ShuffleCase =
   {
      new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 5, new int[] { 1, 6, 2, 7, 3, 8, 4, 9, 5, 10 } },
      // new object[] { new int[] { 2, 5, 1, 3, 4, 7}, 3, new int[] { 2, 3, 5, 4, 1, 7 } },
      // new object[] { new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 } },
      // new object[] { new int[] { 1, 1, 2, 2 }, 2, new int[] { 1, 2, 1, 2 } },
   };

   [TestCaseSource(nameof(ShuffleCase))]
   public void Shuffle(int[] nums, int n, int[] expected)
   {
      var result = this.solution.Shuffle(nums, n);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(ShuffleCase))]
   public void ShuffleTwoIndex(int[] nums, int n, int[] expected)
   {
      var result = this.solution.ShuffleTwoIndex(nums, n);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(ShuffleCase))]
   public void ShuffleLinq(int[] nums, int n, int[] expected)
   {
      var result = this.solution.ShuffleLinq(nums, n);
      Assert.That(result, Is.EqualTo(expected));
   }
}

