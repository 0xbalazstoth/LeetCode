using System.Text.RegularExpressions;
public class Solution {
    public int CountSegments(string s) {
        s = s.TrimEnd();
            s = s.TrimStart();
            string pattern = @"[^0-9A-Za-z ]";
            int zeros = 0;
            if (s.Length != 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                        zeros++;
                }
                string cleaned = Regex.Replace(s, pattern, "");
                if (zeros == s.Length)
                    return 0;
                else
                {
                    int maxCount = 0;
                    char prevChar = ' ';
                    int count = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == ' ')
                            count += 1;
                        else
                            count = 0;
                        if (count > maxCount)
                            maxCount = count;
                        prevChar = s[i];
                    }
                    if (!s.Contains(" "))
                        return 1;
                    else
                        return cleaned.Split(' ').Count() - (maxCount - 1);
                }
            }
            else if (s.Length == 0)
                return 0;
            return 0;
    }
}