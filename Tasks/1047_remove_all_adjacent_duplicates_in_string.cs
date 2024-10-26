using System.Text;

namespace Leetcode;

public partial class Solution
{
   public string RemoveDuplicates(string s) =>
      s.Skip(1).Aggregate((b: new StringBuilder().Append(s[0]), p: s[0]), (state, c) =>
         state.b.Length == 0
            ? (state.b.Append(c), c)
            : state.p == c
               ? (state.b.Remove(state.b.Length - 1, 1),
                  state.b.Length == 0
                     ? char.MinValue
                     : state.b[state.b.Length - 1])
               : (state.b.Append(c), c)
      , state => state.b)
      .ToString();
}