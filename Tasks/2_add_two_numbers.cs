using System;
namespace Leetcode;

public class ListNode
{
   public int val;
   public ListNode? next;

   public ListNode(int val = 0, ListNode? next = null)
   {
      this.val = val;
      this.next = next;
   }
}

public static class ListNodeFabriq
{
   public static ListNode Create(int[] values)
   {
      ListNode cur = new(values[^1]);
      foreach (int val in values.Reverse().Skip(1))
         cur = new(val, cur);
      return cur;
   }
}

public partial class Solution
{
   public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
   {
      ListNode? prev = null, head = null;

      int add = 0;
      while (!(l1 is null && l2 is null && add == 0))
      {
         int val = (l1?.val ?? 0) + (l2?.val ?? 0) + add;
         add = val / 10;
         ListNode node = new(val % 10, null);
         if (head is null) head = node;
         if (prev is not null) prev.next = node;
         prev = node;

         l1 = l1?.next;
         l2 = l2?.next;

      }
      return head!;
   }
}