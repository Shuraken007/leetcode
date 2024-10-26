namespace Leetcode;

public partial class Solution
{
   public int[] Shuffle(int[] nums, int n)
   {
      var arr = new int[n * 2];
      for (int i = 0; i < n; i++)
      {
         arr[2 * i] = nums[i];
         arr[2 * i + 1] = nums[n + i];
      }
      return arr;
   }

   public int[] ShuffleTwoIndex(int[] nums, int n)
   {
      int[] newone = new int[nums.Length];
      for (int i = 0, j = 0; i < nums.Length - n; i++, j++)
      {
         newone[j] = nums[i];
         newone[++j] = nums[n + i];
      }

      return newone;
   }

   public int[] ShuffleLinq(int[] nums, int n) =>
      Enumerable.Range(0, 2 * n).Select(i => nums[i % 2 * n + i / 2]).ToArray();
}