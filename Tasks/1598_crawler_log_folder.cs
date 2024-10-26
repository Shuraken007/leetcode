namespace Leetcode;

public partial class Solution
{
   public int MinOperations(string[] logs)
   {
      int counter = 0;
      foreach (string log in logs)
      {
         if (log == "./") { }
         else if (log == "../" && counter > 0) counter--;
         else counter++;
      }
      return counter;
   }
}