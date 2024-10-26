using System.Collections.Specialized;
using System.Text;

namespace Leetcode;

public partial class Solution
{
   public IList<string> FizzBuzz(int n)
   {
      List<string> l = new(n);
      for (int i = 0; i < n; i++)
      {
         string item = (i % 3 == 0, i % 5 == 0) switch
         {
            (true, true) => "FizzBuzz",
            (true, false) => "Fizz",
            (false, true) => "Buzz",
            (false, false) => i.ToString(),
         };
         l.Add(item);
      }
      return l;
   }

   public IList<string> FizzBuzzLinq1(int n)
   {
      return Enumerable
          .Range(1, n)
          .Select(x =>
              (x % 3, x % 5) switch
              {
                 (0, 0) => "FizzBuzz",
                 (0, _) => "Fizz",
                 (_, 0) => "Buzz",
                 _ => x.ToString()
              })
          .ToList();
   }
}