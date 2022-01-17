public class Solution {
    public string SortSentence(string s) {
        string[,] d = new string[s.Length, 2];
        string[] words = s.Split(' ');
        string r = "";
        
        for (int i = 0; i < words.Length; i++) {
            string word = words[i].Substring(0, words[i].Length - 1);
            string n = words[i][words[i].Length - 1].ToString();
            d[i, 0] = word;
            d[i, 1] = n;
        }
        
        Sort(ref d);

        for (int i = 0; i < d.GetLength(0); i++) {
            r += d[i, 0] + " ";
        }
        
        return r.Substring(0, r.Length - 1).TrimStart();
    }
    
    private void Sort(ref string[,] d) {
        for (int i = 0; i < d.GetLength(0) - 1; i++) {
            for (int j = i + 1; j < d.GetLength(0); j++) {
                int nJ = Convert.ToInt32(d[j, 1]);
                int nI = Convert.ToInt32(d[i, 1]);
                if(nJ < nI) {
                    string[] swap = new string[2];
                    swap[0] = d[j, 0];
                    swap[1] = d[j, 1];
                    
                    d[j, 0] = d[i, 0];
                    d[j, 1] = d[i, 1];
                    
                    d[i, 0] = swap[0];
                    d[i, 1] = swap[1];
                }
            }
        }
    }
}