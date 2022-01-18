public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> l = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(i % 2 != 0)
                for (int k = 0; k < nums[i - 1]; k++)
                {
                    l.Add(nums[i]);
                }
        }

        return l.ToArray();
    }
}