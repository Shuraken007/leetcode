using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] KLengthApartCase =
   {
      new object[] { new int[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2, true },
      new object[] { new int[] { 1, 0, 0, 1, 0, 1 }, 2, false },
   };

   [TestCaseSource(nameof(KLengthApartCase))]
   public void KLengthApart(int[] nums, int k, bool expected)
   {
      var result = this.solution.KLengthApart(nums, k);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(KLengthApartCase))]
   public void KLengthApartLinq(int[] nums, int k, bool expected)
   {
      var result = this.solution.KLengthApartLinq(nums, k);
      Assert.That(result, Is.EqualTo(expected));
   }
}

