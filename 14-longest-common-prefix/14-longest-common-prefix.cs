public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int min = 0;
        while (strs.Length > 0)
        {
            foreach (string s in strs)
            {
                if (s.Length == min || s[min] != strs[0][min]) return strs[0].Substring(0, min);
            }
            min++;
        }
        return "";
    }
}