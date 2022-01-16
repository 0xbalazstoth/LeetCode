public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> h = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            h.Add(nums[i]);
        }
        return h.Count == nums.Length ? false : true;
    }
}