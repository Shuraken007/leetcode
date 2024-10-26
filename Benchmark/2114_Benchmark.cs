using BenchmarkDotNet.Attributes;
using Leetcode;

namespace Benchmark
{
   [MemoryDiagnoser] // измерение использование памяти
   [RankColumn] // оценка для тестирования методов
   public class Solution2114
   {

      private Solution solution;

      [GlobalSetup]
      public void Setup()
      {
         solution = new Solution();
      }

      public IEnumerable<string[]> Input()
      {
         yield return new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
         yield return new string[] { "please wait", "continue to fight", "continue to win" };
      }

      [Benchmark(Baseline = true)]
      [ArgumentsSource(nameof(Input))]
      public void MostWordsFoundBase(string[] input)
      {
         solution.MostWordsFound(input);
      }

      [Benchmark]
      [ArgumentsSource(nameof(Input))]
      public void MostWordsFoundLinq(string[] input)
      {
         solution.MostWordsFoundLinq(input);
      }
   }
}
