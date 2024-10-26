using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] MinOperationsCase =
   {
      new object[] { new string[] { "d1/", "d2/", "../", "d21/", "./" }, 2 },
      new object[] { new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }, 3 },
      new object[] { new string[] { "d1/", "../", "../", "../" }, 0 },
   };

   [TestCaseSource(nameof(MinOperationsCase))]
   public void MinOperations(string[] input, int expected)
   {
      var result = this.solution.MinOperations(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

