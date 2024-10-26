using BenchmarkDotNet.Attributes;
using Leetcode;

namespace Benchmark
{
   [MemoryDiagnoser] // измерение использование памяти
   [RankColumn] // оценка для тестирования методов
   public class Solution1544
   {

      public IEnumerable<string> Input()
      {
         yield return "leEeetcode";
         yield return "abBAcC";
      }

      [Benchmark(Baseline = true)]
      [ArgumentsSource(nameof(Input))]
      public void MakeGood(string input)
      {
         new Solution().MakeGood(input);
      }
   }
}
