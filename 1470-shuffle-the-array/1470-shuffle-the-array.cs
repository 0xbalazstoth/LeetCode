public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] r = new int[nums.Length];
        int j = 0;
        
        for (int i = 0; i < n; ++i)
        {
            r[j] = nums[i];
            r[j+1] = nums[i + n];
            j += 2;
        }
        
        return r; 
    }
}