using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] ThousandSeparatorCase =
   {
      new object[] { 0, "0" },
      new object[] { 987, "987" },
      new object[] { 1234, "1.234"},
      new object[] { 11111111, "11.111.111.1"},
   };

   [TestCaseSource(nameof(ThousandSeparatorCase))]
   public void ThousandSeparatorNumberFormat1N0(int input, string expected)
   {
      var result = this.solution.ThousandSeparatorNumberFormat1N0(input);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(ThousandSeparatorCase))]
   public void ThousandSeparatorStringFormat2N0(int input, string expected)
   {
      var result = this.solution.ThousandSeparatorStringFormat2N0(input);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(ThousandSeparatorCase))]
   public void ThousandSeparatorSharp(int input, string expected)
   {
      var result = this.solution.ThousandSeparatorSharp(input);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(ThousandSeparatorCase))]
   public void ThousandSeparatorSharpFormatInfo(int input, string expected)
   {
      var result = this.solution.ThousandSeparatorSharpFormatInfo(input);
      Assert.That(result, Is.EqualTo(expected));
   }

   [TestCaseSource(nameof(ThousandSeparatorCase))]
   public void ThousandSeparatorLinq(int input, string expected)
   {
      var result = this.solution.ThousandSeparatorLinq(input);
      Assert.That(result, Is.EqualTo(expected));
   }
}

