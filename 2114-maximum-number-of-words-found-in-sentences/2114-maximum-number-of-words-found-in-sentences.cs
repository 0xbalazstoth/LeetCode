public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = Int32.MinValue;
        for (int i = 0; i < sentences.Length; i++) {
            string s = sentences[i];
            string[] sentence = s.Split(' ');
            if (sentence.Length > max) {
                max = sentence.Length;
            }
        }
        return max;
    }
}