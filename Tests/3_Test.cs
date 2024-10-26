using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] LengthOfLongestSubstringCase =
   {
      new object[] { "abcabcbb", 3 },
      new object[] { "bbbbb", 1 },
      new object[] { "pwwkew", 3},
      new object[] { " ", 1},
   };

   [TestCaseSource(nameof(LengthOfLongestSubstringCase))]
   public void LengthOfLongestSubstring(string input, int expected)
   {
      var result = this.solution.LengthOfLongestSubstring3(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

