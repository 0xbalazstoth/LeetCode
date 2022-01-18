public class Solution {
    public void SortColors(int[] nums) {
        SwapSort(ref nums);
    }
    
    public void SwapSort(ref int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] > nums[j]) {
                    int swap = nums[i];
                    nums[i] = nums[j];
                    nums[j] = swap;
                }    
            }
        }
    }
}