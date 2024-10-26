using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] CanFormArrayCase =
   {
      new object[] { new int[] { 15, 88 }, new int[][] { ([88]), ([15]) }, true },
      new object[] { new int[] { 49, 18, 16 }, new int[][] { ([16, 18, 49 ]) }, false },
      new object[] { new int[] { 91, 4, 64, 78 }, new int[][] { ([78]) , ([4, 64]), ([91]) }, true },
   };

   [TestCaseSource(nameof(CanFormArrayCase))]
   public void CanFormArray(int[] arr, int[][] pieces, bool expected)
   {
      var result = this.solution.CanFormArray(arr, pieces);
      Assert.That(result, Is.EqualTo(expected));
   }
}

