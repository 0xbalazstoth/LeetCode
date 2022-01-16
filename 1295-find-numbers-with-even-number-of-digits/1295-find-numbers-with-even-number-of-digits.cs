public class Solution {
    public int FindNumbers(int[] nums) => nums.Where(x => x.ToString().Length % 2 == 0).Count();
}