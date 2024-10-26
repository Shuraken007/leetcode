namespace Leetcode;

public partial class Solution
{
   public bool CanFormArray(int[] arr, int[][] pieces)
   {
      Dictionary<int, int> links = new();
      for (int j = 0; j < pieces.Length; j++)
         links.Add(pieces[j][0], j);

      int i = 0;
      while (i < arr.Length)
      {
         int n = arr[i];
         if (!links.ContainsKey(n)) return false;
         int[] piece = pieces[links[n]];
         foreach (int num in piece.Skip(1))
         {
            i++;
            if (i >= arr.Length) break;
            if (num != arr[i]) return false;
         }
         i++;
      }
      return true;
   }

   public bool CanFormArrayLinq1(int[] arr, int[][] pieces) => pieces
       .OrderBy(p => Array.IndexOf(arr, p[0]))
       .SelectMany(p => p)
       .SequenceEqual(arr);

   public bool CanFormArrayLinq2(int[] arr, int[][] pieces)
   {
      var dic = pieces.ToDictionary(p => p[0]);
      return arr
         .SelectMany(
            a => dic.GetValueOrDefault(a, []))
         .SequenceEqual(arr);
   }

   // Array.Sort(pieces, (x, y) => {
   //          return dict.GetValueOrDefault(x[0], -1)
   //                 .CompareTo(dict.GetValueOrDefault(y[0], -1));   
}