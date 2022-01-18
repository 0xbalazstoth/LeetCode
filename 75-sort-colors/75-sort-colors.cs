public class Solution {
    public void SortColors(int[] nums) {
        // SwapSort(ref nums);
        // MinimumSort(ref nums);
        // BubbleSort(ref nums);
        BetterBubbleSort(ref nums);
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
    
    public void MinimumSort(ref int[] nums) {
        for (int i = 0; i < nums.Length - 1; i++) {
            int min = i;
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[min] > nums[j]) {
                    min = j;
                }
            }
            int swap = nums[i];
            nums[i] = nums[min];
            nums[min] = swap;
        }
    }
    
    public void BubbleSort(ref int[] nums) {
        for (int i = nums.Length - 1; i >= 0; i--) {
            for (int j = 0; j < i; j++) {
                if (nums[j] > nums[j + 1]) {
                    int swap = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = swap;
                }
            }
        }
    }
    
    public void BetterBubbleSort(ref int[] nums) {
        int i = nums.Length - 1;
        while(i > 0) {
            int index = -1;
            for (int j = 0; j < i; j++) {
                if (nums[j] > nums[j + 1]) {
                    int swap = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = swap;
                    index = j;
                }
            }
            i = index;
        }
    }
}