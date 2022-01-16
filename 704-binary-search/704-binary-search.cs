public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int n = nums.Length - 1;
        int right = n;
        int center = (left + right) / 2;
        while ((left <= right) && (nums[center] != target)) {
            if (nums[center] > target) {
                right = center - 1;
            } else {
                left = center + 1;
            }
            center = (left + right) / 2;
        }
        bool found = (left <= right);
        if (found) {
            int idx = center;
        return idx;
        } else {
            return -1;
        }
    }
}