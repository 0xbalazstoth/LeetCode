public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length != 0) {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                nums[i] = nums[j];
                
                while (j < nums.Length - 1 && nums[j] == nums[j + 1])
                {
                    j++;
                }
                
                i++;
            }

            return i;
        } else {
            return 0;
        }
    }
}