using System.Text;

namespace Leetcode;

public partial class Solution
{

   public int MinLength(string s)
   {
      string close = "BD";
      var map_open_close = new Dictionary<char, char>
      {
         ['A'] = 'B',
         ['C'] = 'D'
      };
      Stack<char> st = new(s[0]);
      int counter = s.Length;
      foreach (char c in s.Skip(0))
      {
         if (!close.Contains(c) || st.Count == 0) { st.Push(c); continue; }
         char prev = st.Peek();
         st.Push(c);
         char prev_expected = map_open_close.GetValueOrDefault(prev, char.MinValue);
         if (prev_expected == c)
         {
            st.Pop();
            st.Pop();
            counter -= 2;
         }
      }
      return counter;
   }
}