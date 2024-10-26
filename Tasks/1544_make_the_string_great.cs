using System.Text;

namespace Leetcode;

public partial class Solution
{
   public string MakeGood(string s)
   {
      Stack<char> st = new();
      st.Push(s[0]);
      foreach (char c in s.Skip(1))
      {
         bool prev_existed = st.TryPeek(out char prev);
         st.Push(c);
         if (!prev_existed) continue;
         if (prev != c && char.ToLower(prev) == char.ToLower(c))
         {
            st.Pop(); st.Pop();
         }
      }
      return new string(st.Reverse().ToArray());
   }

   public string MakeGoodLinq(string s) =>
      s.Aggregate((sb: new StringBuilder(), prev: char.MinValue),
         (state, c) =>
            state.sb.Length > 0
            && Math.Abs(c - state.prev) == 'a' - 'A'
               ? (state.sb.Remove(state.sb.Length - 1, 1),
                  state.sb.Length > 0 ? state.sb[state.sb.Length - 1] : char.MinValue)
               : (state.sb.Append(c), c),
            state => state.sb.ToString());
}