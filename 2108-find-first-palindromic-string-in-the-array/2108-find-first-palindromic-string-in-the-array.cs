public class Solution {
    public string FirstPalindrome(string[] words) {
        string r = "";
        
        int k = 0;
        for (int i = 0; i < words.Length; i++) {
            string word = words[i];
            string rev = "";
            for (int j = word.Length - 1; j >= 0; j--) {
                rev += word[j];
            }
            
            if (word == rev) {
                r = rev;
                break;
            }
        }
        
        return r;
    }
}