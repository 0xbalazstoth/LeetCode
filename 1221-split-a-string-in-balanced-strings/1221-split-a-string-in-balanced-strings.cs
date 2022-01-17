public class Solution {
    public int BalancedStringSplit(string s) {
        int lC = 0;
        int rC = 0;
        int r = 0;
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            
            if (c == 'L') {
                lC++;
            } else if (c == 'R') {
                rC++;
            }
            
            if (lC == rC) {
                r++;
            }
        }
        return r;
    }
}