public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] nums = new int[m + n];
        for (int i = 0; i < m + n; i++) {
            if (i < m) {
                int num1 = nums1[i];
                nums[i] = num1;
            }
            
            if (i >= m) {
                int num2 = nums2[i - m];
                nums[i] = num2;
            }
        }
        
        for (int i = 0; i < nums1.Length; i++) {
            nums1[i] = nums[i];
        }
        
        Array.Sort(nums1);
    }
}