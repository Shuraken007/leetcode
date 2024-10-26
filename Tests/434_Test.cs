using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] CountSegmentsCase =
   {
      new object[] { "Hello, my name is John", 5 },
      new object[] { "Hello", 1 },
      new object[] { "", 0 },
      new object[] { "Of all the gin joints in all the towns in all the world,   ", 13 },
      new object[] { "    foo    bar", 2 },
   };

   [TestCaseSource(nameof(CountSegmentsCase))]
   public void CountSegmentsSplitOptions(string input, int expected)
   {
      var result = this.solution.CountSegmentsSplitOptions(input);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(CountSegmentsCase))]
   public void CountSegmentsRe(string input, int expected)
   {
      var result = this.solution.CountSegmentsRe(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

