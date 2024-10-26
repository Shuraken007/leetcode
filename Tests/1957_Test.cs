using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{
   [TestCase("leeetcode", "leetcode")]
   [TestCase("aaabaaaa", "aabaa")]
   public void MakeFancyString(string input, string expected)
   {
      var result = this.solution.MakeFancyString(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

