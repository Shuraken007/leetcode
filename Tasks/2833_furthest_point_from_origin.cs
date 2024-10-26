using System.Text;

namespace Leetcode;

public partial class Solution
{

   public int FurthestDistanceFromOrigin(string moves) =>
      Math.Abs(moves.Count(c => c == 'L')
         - moves.Count(c => c == 'R'))
      + moves.Count(c => c == '_');
}