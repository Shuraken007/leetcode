using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{
   [TestCase("2080-02-29", "100000100000-10-11101")]
   [TestCase("1900-01-01", "11101101100-1-1")]
   public void ConvertDateToBinary(string input, string expected)
   {
      var result = this.solution.ConvertDateToBinary(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

