using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{
   [TestCase("leEeetcode", "leetcode")]
   [TestCase("abBAcC", "")]
   public void MakeGood(string input, string expected)
   {
      var result = this.solution.MakeGood(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

