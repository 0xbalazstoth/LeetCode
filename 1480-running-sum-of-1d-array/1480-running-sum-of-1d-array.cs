public class Solution {
    public int[] RunningSum(int[] nums) {
        int running = 0;
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            running += nums[i];
            nums[index++] = running;
        }
        return nums;
    }
}