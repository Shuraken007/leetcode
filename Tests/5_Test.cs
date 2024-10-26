using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] LongestPalindrome5Case =
   {
      new object[] { "babad", "bab" },
      new object[] { "cbbd", "bb" },
   };

   [TestCaseSource(nameof(LongestPalindrome5Case))]
   public void LongestPalindrome5(string input, string expected)
   {
      var result = this.solution.LongestPalindrome5(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

