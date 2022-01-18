public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = Int32.MinValue;
        for (int c = 0; c < accounts.Length; c++) {
            int m = 0;
            for (int r = 0; r < accounts[c].Length; r++) {
                m += accounts[c][r];
            }
            
            if (m > max) {
                max = m;
            }
        }
        return max;
    }
}