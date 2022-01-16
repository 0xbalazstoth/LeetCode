public class Solution {
    public int CountNegatives(int[][] grid) => grid.Sum(r => r.Count(i => i < 0));
}