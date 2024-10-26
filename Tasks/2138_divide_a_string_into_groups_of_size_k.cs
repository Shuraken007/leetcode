namespace Leetcode;

public partial class Solution
{
   public string[] DivideString(string s, int k, char fill)
   {
      var l = new List<string>();

      for (int i = 0; i < s.Length / k; i++)
      {
         l.Add(s.Substring(i * k, k));
      }

      if (s.Length % k == 0) return l.ToArray();

      string reminder = s.Substring(s.Length - s.Length % k, s.Length % k)
                        .PadRight(k, fill);
      l.Add(reminder);
      return l.ToArray();
   }

   public string[] DivideStringLinq1(string s, int k, char fill)
       => s.PadRight((s.Length + k - 1) / k * k, fill)
           .Chunk(k)
           .Select(chunk => new string(chunk))
           .ToArray();

   public string[] DivideStringLinq2(string s, int k, char fill)
       => s.Chunk(k).Select(_ => new string(_).PadRight(k, fill)).ToArray();
}