using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{
   [TestCase("iloveleetcode", new string[] { "i", "love", "leetcode", "apples" }, true)]
   [TestCase("iloveleetcode", new string[] { "apples", "i", "love", "leetcode" }, false)]
   public void IsPrefixString(string input_str, string[] input_words, bool expected)
   {
      var result = this.solution.IsPrefixString(input_str, input_words);
      Assert.That(result, Is.EqualTo(expected));
   }
}

