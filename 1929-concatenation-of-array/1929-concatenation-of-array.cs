public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] nums2 = new int[nums.Length + nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            nums2[i] = nums[i];
        }
        
        int j = 0;
        for (int i = nums.Length; i < nums2.Length; i++) {
            nums2[i] = nums[j++];
        }
        return nums2;
    }
}