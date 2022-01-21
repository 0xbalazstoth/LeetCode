public class Solution {
    public bool HalvesAreAlike(string s) {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int h = s.Length / 2;
        int a = 0;
        int b = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (i < h) {
                for (int j = 0; j < vowels.Length; j++) {
                    if (s[i] == vowels[j]) {
                        a++;
                    }
                }
            }
            
            if (i >= h) {
                for (int j = 0; j < vowels.Length; j++) {
                    if (s[i] == vowels[j]) {
                        b++;
                    }
                }
            }
        }
        
        return a == b ? true : false;
    }
}