public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> dict = new Dictionary<char, char>();
    for(int i = 0; i < s.Length; i++)
        if(dict.ContainsKey(s[i]) && dict[s[i]] != t[i]) return false;
        else if (!dict.ContainsKey(s[i]) && dict.ContainsValue(t[i])) return false;
        else if (!dict.ContainsKey(s[i]) && !dict.ContainsValue(s[i])) dict.Add(s[i], t[i]);
    return true;
    }
}