public class Solution {
    public int LengthOfLastWord(string s) {
        if (s.Length == 0)
                return 0;
        else if (!s.Contains(" "))
            return s.Length;
        else
        {
            string[] split = s.Trim().Split(' ').ToArray();
            return split[split.Length - 1].Length;
        }
    }
}