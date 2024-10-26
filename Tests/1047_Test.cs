using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{
   [TestCase("abbaca", "ca")]
   [TestCase("azxxzy", "ay")]
   public void RemoveDuplicates(string input, string expected)
   {
      var result = this.solution.RemoveDuplicates(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

