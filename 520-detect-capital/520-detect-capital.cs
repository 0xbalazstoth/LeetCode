public class Solution {
    public bool DetectCapitalUse(string word) {
        int countRemain = 0;
        int countLowers = 0;
        if (word.Length == 0 && word == "")
            return false;
        else if (word.Length == 1)
        {
            if (Char.IsUpper(word[0]))
                return true;
            return true;
        }
        else
        {
            if (Char.IsUpper(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (Char.IsUpper(word[i]))
                        countRemain++;
                }
                if (countRemain == 0 && Char.IsUpper(word[0]))
                    return true;
                else if (Char.IsUpper(word[0]) && countRemain == (word.Length - 1))
                    return true;
                return false;
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.IsLower(word[i]))
                        countLowers++;
                }
                if (countLowers == word.Length)
                    return true;
                return false;
            }
        }
    }
}