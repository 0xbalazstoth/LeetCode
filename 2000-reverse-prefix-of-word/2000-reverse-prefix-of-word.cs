public class Solution {
    public string ReversePrefix(string word, char ch) {
        string rev = "";
        
        if (!word.Contains(ch)) {
            return word;
        } else {
            int i = 0;
            while (i < word.Length && word[i] != ch) {
                i++;
            }
            
            bool y = i < word.Length && word[i] == ch;
            if (y) {
                // abcd efd -> // dcba efd
                string revTemp = word.Substring(0, i + 1);
                
                for (int j = revTemp.Length - 1; j >= 0; j--) {
                    rev += revTemp[j];
                }
            }
            return rev + word.Substring(rev.Length, word.Length - rev.Length);
        }
    }
}