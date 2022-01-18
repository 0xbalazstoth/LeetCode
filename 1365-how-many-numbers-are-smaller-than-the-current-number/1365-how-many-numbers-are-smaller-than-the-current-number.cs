public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        return nums.Select(x => (nums.Where(i => i < x).Count())).ToArray();
    }
}