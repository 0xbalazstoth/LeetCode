public class Solution {
    public int FindDuplicate(int[] nums) {
        if (nums.Length == 0)
            return 0;
        else
        {
            SortedDictionary<int, int> sorted = new SortedDictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (sorted.ContainsKey(nums[i]))
                    sorted[nums[i]]++;
                else
                    sorted[nums[i]] = 1;
            }
            var maxDup = sorted.Select(x => new { Number = x.Key, Count = x.Value }).OrderByDescending(x => x.Count).Select(x => x.Number).First();
            return maxDup;
        }
    }
}