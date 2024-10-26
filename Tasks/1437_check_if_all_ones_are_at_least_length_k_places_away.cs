namespace Leetcode;

public partial class Solution
{
   public bool KLengthApart(int[] nums, int k)
   {
      int last_one = -k - 1;
      for (int i = 0; i < nums.Length; i++)
      {
         if (nums[i] != 1) continue;
         if (i - last_one - 1 < k) return false;
         last_one = i;
      }
      return true;
   }

   public bool KLengthApartLinq(int[] nums, int k)
   {
      var ones = Enumerable.Range(0, nums.Length).Where(i => nums[i] == 1);
      return ones.Skip(1).Zip(ones).All(p => p.First - p.Second > k);
   }
}