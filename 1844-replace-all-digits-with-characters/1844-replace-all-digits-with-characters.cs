public class Solution {
    public string ReplaceDigits(string s) {
        char[,] sC = new char[s.Length, 2];
        string r = "";
        for (int i = 1; i <= s.Length; i++) {
            //sC[i, 0] = s[i];
            //sC[i, 1] = 97 + ((int)s[i]);

            if (i < s.Length) {
                if (((i - 1) % 2 == 0) && (i) % 2 != 0) {
                    // Console.WriteLine($"{s[i - 1]} {s[i]}");
                    int c = ((int)s[i - 1]) + (Convert.ToInt32(s[i])) - 48;
                    char cC = (char)c;
                    r += s[i - 1].ToString() + cC;
                }
            }
        }
        
        if (r.Length == s.Length) {
            return r;
        } else {
            return r + s[s.Length - 1];
        }
    }
}