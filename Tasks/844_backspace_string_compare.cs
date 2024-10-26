using System.Text;

namespace Leetcode;

public partial class Solution
{
   public string TypedToString(string s)
   {
      Stack<char> st = new();
      foreach (var c in s)
      {
         if (c == '#') st.TryPop(out _);
         else st.Push(c);
      }
      return new string(st.ToArray());
   }

   public bool BackspaceCompare(string s, string t) =>
      TypedToString(s) == TypedToString(t);
}