namespace Leetcode;

public partial class Solution
{
   public int[] RunningSum(int[] nums)
   {
      var arr = new int[nums.Length];
      int sum = 0;
      for (int i = 0; i < nums.Length; i++)
         arr[i] = sum += nums[i];
      return arr;
   }

   public int[] RunningSumLinq1(int[] nums) =>
      nums.Select((_, i) =>
         nums.Take(i + 1).Sum())
      .ToArray();

   public int[] RunningSumLinq2(int[] nums) =>
      nums.Select((num, i) =>
         i is 0 ? num : nums[i] += nums[i - 1])
      .ToArray();
}