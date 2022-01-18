public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var merged = nums1.Concat(nums2).OrderBy(x => x).ToList();
        int midOdd = 0;
        int midEvenFirst = 0;
        int midEvenSecond = 0;
        if (merged.Count % 2 != 0)
        {
            for (int i = 0; i < merged.Count; i++)
            {
                midOdd = merged[merged.Count / 2];
            }
            return midOdd;
        }
        else if(merged.Count % 2 == 0)
        {
            for (int i = 0; i < merged.Count; i++)
            {
                midEvenFirst = merged[(merged.Count - 1) / 2];
                midEvenSecond = merged[merged.Count / 2];
            }
            return Math.Round(((double)midEvenFirst + (double)midEvenSecond) / 2, 2);
        }
        return 0;
    }
}