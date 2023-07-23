public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        // Left sum
        // [10, 4, 8, 3]
            // 0 + 0 = 0
            // 0 + 10 = 10
            // 10 + 4 = 14
            // 14 + 8 = 22
            // 22 + 3 = 25 (The array's length is 4, so this will be exluded after the 4th element)

        // Right sum (reversed array)
        // [3, 8, 4, 10]
            // 0 + 0 = 0
            // 0 + 3 = 3
            // 3 + 8 = 11
            // 11 + 4 = 15
            // 15 + 10 = 25 (The array's length is 4, so this will be exluded after the 4th element)

        int n = nums.Length;

        if (n == 0)
        {
            return nums;
        }

        if (n == 1)
        {
            return new int[] { 0 };
        }

        int[] result = new int[n];

        // Left sum
        int[] leftSumArr = new int[n];
        leftSumArr[0] = 0;
        for (int i = 1; i < n; i++)
        {
            leftSumArr[i] = leftSumArr[i - 1] + nums[i - 1];
        }

        // Right sum
        int[] rightSumArr = new int[n];
        rightSumArr[0] = 0;
        int j = 0;
        for (int i = n - 1; i >= 1; i--)
        {
            j++;
            rightSumArr[j] = rightSumArr[j - 1] + nums[i];
        }

        // Result
        for (int i = 0; i < n; i++)
        {
            int left = leftSumArr[i];
            int right = rightSumArr[n - (i + 1)];

            result[i] = System.Math.Abs(left - right); // Abs
        }

        return result;
    }
}