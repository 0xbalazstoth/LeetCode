public class Solution {
    public int SingleNumber(int[] nums) {
        SortedDictionary<int, int> sorted = new SortedDictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (sorted.ContainsKey(nums[i]))
                sorted[nums[i]]++;
            else
                sorted[nums[i]] = 1;
        }
        int mini = sorted.Select(x => new { number = x.Key, count = x.Value }).OrderBy(x => x.count).Select(x => x.number).First();
        return mini;
    }
}