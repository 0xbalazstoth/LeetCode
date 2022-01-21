public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] words = s.Split(' ');
        if (k >= words.Length) {
            return s;
        } else {
            string r = "";
            for (int i = 0; i < k; i++) {
                r += words[i] + " ";
            }
            
            return r.Substring(0, r.Length - 1);
        }
    }
}