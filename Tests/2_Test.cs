using NUnit.Framework;
using Leetcode;

namespace PartialSolutionTest;

[TestFixture]
public partial class SolutionTest
{

   static object[] AddTwoNumbersCase =
   {
      new object[] { ListNodeFabriq.Create(new int[] { 2, 4, 3}), ListNodeFabriq.Create(new int[] { 5, 6, 4}), new List<int> { 7, 0, 8} },
      new object[] { ListNodeFabriq.Create(new int[] { 0 }), ListNodeFabriq.Create(new int[] { 0 }), new List<int> { 0 } },
      new object[] { ListNodeFabriq.Create(new int[] { 9 }), ListNodeFabriq.Create(new int[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }), new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 } },
   };

   [TestCaseSource(nameof(AddTwoNumbersCase))]
   public void AddTwoNumbers(ListNode l1, ListNode l2, List<int> expected)
   {
      var result = this.solution.AddTwoNumbers(l1, l2);
      List<int> result_as_list = new();
      while (result is not null)
      {
         result_as_list.Add(result.val);
         result = result.next;
      }
      // Console.WriteLine("[{0}]", string.Join(' ', result_as_list.ToArray()));
      Assert.That(result_as_list, Is.EqualTo(expected));
   }
}

