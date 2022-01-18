public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) => nums2.Intersect(nums1).Distinct().ToArray();
}