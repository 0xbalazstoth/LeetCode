using System;
using System.Collections.Generic;
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        IDictionary<int, int> numsByValue = new Dictionary<int, int>();
        for (int i = 0; i.CompareTo(nums.Length).Equals(-1); i++)
        {
            int diff = target - nums[i];
            if (numsByValue.ContainsKey(diff))
            {
                return new int[] { numsByValue[diff], i };
            }
            else
            {
                numsByValue[nums[i]] = i;
            }
        }
        
        return null;
    }
}