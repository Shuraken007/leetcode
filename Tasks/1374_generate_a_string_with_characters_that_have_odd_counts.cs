using System.Text;

namespace Leetcode;

public partial class Solution
{
   private static readonly Random rnd = new Random();
   private char default_char = char.MinValue;

   public int GetRndOddLength(int max)
   {
      int l = 0;
      while (l % 2 == 0)
         l = rnd.Next(1, max);
      return l;
   }

   public char GetRndUniqueChar(HashSet<char> hash)
   {
      char c = default_char;
      while (hash.Contains(c))
         c = (char)rnd.Next('a', 'z');
      hash.Add(c);
      return c;
   }

   public string GenerateTheString(int n)
   {
      StringBuilder sb = new();
      var hash = new HashSet<char> { default_char };

      while (n > 0)
      {
         int l = GetRndOddLength(n);
         char c = GetRndUniqueChar(hash);
         Console.WriteLine($"l: {l}, c: {c}");
         sb.Append(c, l);
         n -= l;
      }

      return sb.ToString();
   }

   public string GenerateTheStringOptimisationCreate(int n)
       => string.Create(n, 0, (characters, _) =>
           {
              for (int index = 0; index < n; index++)
              {
                 characters[index] = 'a';
              }

              if (n % 2 == 0) characters[0] = 'b';
           }
       );
}