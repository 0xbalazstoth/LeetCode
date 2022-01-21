public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string w1Str = String.Concat(word1);
        string w2Str = String.Concat(word2);
        int n = w1Str.Length;
        int m = w2Str.Length;
        
        if (n == m) {
            char[] w1 = w1Str.ToCharArray();
            char[] w2 = w2Str.ToCharArray();
            
            int c = 0;
            for (int i = 0; i < w1.Length; i++) {
                if (w1[i] == w2[i]) {
                    c++;
                }
            }
            
            return (c == w1.Length) ? true : false;
        } else {
            return false;
        }
    }
}