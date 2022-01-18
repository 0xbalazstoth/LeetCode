public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        // 2, 3, 5, 1, 3 = 5, 6, 8, 4, 6;
        // 8 - 5 = 3 <= 3 T
        // 8 - 6 = 2 <= 3 T
        // 8 - 8 = 0 <= 3 T
        // 8 - 4 = 4 > 3 F
        // 8 - 6 = 2 <= 3 T

        // 4, 2, 1, 1, 2 = 5, 3, 2, 2, 3
        // 5 - 5 = 0 <= 1 T
        // 5 - 3 = 2 > 1 F
        // 5 - 2 = 3 > 1 F
        // 5 - 2 = 3 > 1 F
        // 5 - 3 = 2 > 1 F

        // 12, 1, 12 = 22, 11, 22
        // 22 - 22 = 0 <= 10 T
        // 22 - 11 = 11 > 10 F
        // 22 - 22 = 0 <= 10 T
        
        bool[] l = new bool[candies.Length];
        int j = 0;
        int max = Int32.MinValue;
        for (int i = 0; i < candies.Length; i++) {
            int c = candies[i] + extraCandies;
            if (c > max) {
                max = c;
            }
        }
        
        for (int i = 0; i < candies.Length; i++) {
            int c = candies[i] + extraCandies;
            if ((max - c) <= extraCandies) {
                l[j++] = true;
            } else {
                l[j++] = false;
            }
        }
        
        return l;
    }
}