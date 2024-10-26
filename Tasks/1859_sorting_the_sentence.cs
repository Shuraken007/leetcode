using System.Text;

namespace Leetcode;

public partial class Solution
{

   public string SortSentence(string s)
   {
      return s.Split(' ')
         .Select(word => new { index = word[^1] - '0' - 1, word = word[..^1] })
         .OrderBy(item => item.index)
         .Select(item => item.word)
         .Aggregate((str, w) => str + ' ' + w);
   }
}