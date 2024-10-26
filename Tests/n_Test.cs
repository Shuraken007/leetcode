using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] NProblemCase =
   {
      new object[] { "test", 0 },
   };

   [TestCaseSource(nameof(NProblemCase))]
   public void NProblem(string input, int expected)
   {
      var result = this.solution.NProblem(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

