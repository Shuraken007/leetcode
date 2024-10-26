using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] FindMedianSortedArraysCase =
   {
      new object[] { new int[] { 1, 3 }, new int[] { 2 }, 2.0 },
      new object[] { new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5 },
   };

   [TestCaseSource(nameof(FindMedianSortedArraysCase))]
   public void FindMedianSortedArrays(int[] nums1, int[] nums2, int expected)
   {
      var result = this.solution.FindMedianSortedArrays(nums1, nums2);
      Assert.That(result, Is.EqualTo(expected));
   }
}

