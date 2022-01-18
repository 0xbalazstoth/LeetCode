public class Solution {
    public void MoveZeroes(int[] nums)
    {
        List<int> cleaned = new List<int>();
        int zeros = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                cleaned.Add(nums[i]);
            if (nums[i] == 0)
                zeros++;
        }
        int[] newArr = cleaned.ToArray();
        for (int i = 0; i < zeros; i++)
        {
            newArr = newArr.Concat(new[] { 0 }).ToArray();
        }
        Array.Clear(nums, 0, nums.Length);
        for (int i = 0; i < newArr.Length; i++)
        {
            nums[i] = newArr[i];
        }
    }
}