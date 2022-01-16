public class Solution {
    public bool IsAnagram(string s, string t) {
        string word1 = s;
        string word2 = t;
        bool lengthOf = (word1.Length != word2.Length) ? false : true;
        if (lengthOf)
        {
            for (int i = 0; i < word1.Length; i++)
            {
                string temp = word1;
                char character = word1[i];
                bool hasCharacter = false;
                int index = -1;
                for (int j = 0; j < word2.Length; j++)
                {
                    if (character == word2[j])
                    {
                        hasCharacter = true;
                        index = j;
                        break;
                    }
                }
                if (hasCharacter)
                    word2 = word2.Remove(index, 1);
                else
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
}