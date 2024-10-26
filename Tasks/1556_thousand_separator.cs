using System.Text;

namespace Leetcode;

public partial class Solution
{
   public string ThousandSeparatorNumberFormat1N0(int n) =>
      n.ToString("N0").Replace(',', '.');

   public string ThousandSeparatorStringFormat2N0(int n) =>
      string.Format("{0:n0}", n).Replace(',', '.');

   public string ThousandSeparatorSharp(int n) =>
      string.Format("{0:#,#0}", n).Replace(',', '.');

   public string ThousandSeparatorSharpFormatInfo(int n) =>
      n.ToString("N", new System.Globalization.NumberFormatInfo
      {
         NumberGroupSizes = ([3]),
         NumberGroupSeparator = ".",
         NumberDecimalDigits = 0
      });

   public string ThousandSeparatorLinq(int n) =>
      Convert.ToString(n)
         .Reverse()
         .Chunk(3)
         .Reverse()
         .Select(w => new string(w.Reverse().ToArray()))
         .Aggregate(
            new StringBuilder(), (b, c) =>
            b.Length == 0 ? b.Append(c) : b.Append('.').Append(c))
         .ToString();
}