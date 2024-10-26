using System.Collections.Specialized;
using System.Text;

namespace Leetcode;

public partial class Solution
{
   private readonly HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };
   private StringBuilder goat = new("maa");

   public string ToGoatLatin(string sentence)
   {
      string[] words = sentence.Split(' ');
      StringBuilder new_sentence = new();

      for (int i = 0; i < words.Length; i++)
      {
         string word = words[i];

         if (vowels.Contains(char.ToLower(word[0])))
         {
            new_sentence.Append(word)
                        .Append(goat);
         }
         else
         {
            new_sentence.Append(word.Substring(1))
                        .Append(word[0])
                        .Append(goat);
         }
         new_sentence.Append('a', i);
         if (i != words.Length - 1) new_sentence.Append(' ');
      }
      return new_sentence.ToString();
   }

   public string ToGoatLatinLinq(string sentence)
       => string.Join(" ", sentence.Split(' ').Select(
         (word, i) => new string(
            "aeiouAEIOU".Contains(word[0]) ?
            word :
            word[1..] + word[0]) + "maa" + new string('a', i)
      ));

   public string ToGoatLatinLinq1(string sentence)
       => string.Join(' ', sentence.Split(' ').Select(ConvertWordToGoatLatin));

   private static string ConvertWordToGoatLatin(string word, int index)
       => char.ToLower(word[0]) is not ('a' or 'e' or 'i' or 'o' or 'u')
           ? word[1..] + word[0] + "ma" + new string('a', index + 1)
           : word + "ma" + new string('a', index + 1);
}