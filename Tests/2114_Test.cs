using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{
   [TestCase(new string[] {
      "alice and bob love leetcode", "i think so too", "this is great thanks very much"
   }, 6)]
   [TestCase(new string[] {
      "please wait", "continue to fight", "continue to win"
   }, 3)]
   public void MostWordsFound(string[] input, int expected)
   {
      var result = this.solution.MostWordsFound(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

