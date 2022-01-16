public class Solution {
    public string RestoreString(string s, int[] indices) {
        int[,] si = new int[indices.Length, 2];
        for (int i = 0; i < indices.Length; i++) {
            // [4, c] -> [0, l]
            // [5, o] -> [1, e]
            // [6, d] -> [2, e]
            // [7, e] -> [3, t]
            // [0, l] -> [4, c]
            // [2, e] -> [5, o]
            // [1, e] -> [6, d]
            // [3, t] -> [7, e]

            si[i, 0] = indices[i];
            si[i, 1] = (int)s[i];
        }
        
        SortMatrix(ref si);
        string shuffledStr = "";
        for (int i = 0; i < si.GetLength(0); i++) {
            shuffledStr += (char)si[i, 1];
        }

        return shuffledStr;
    }
    
    private void SortMatrix(ref int[,] matrix) {
        for (int r = 0; r < matrix.GetLength(0) - 1; r++) {
            for (int c = r + 1; c < matrix.GetLength(0); c++) {
                if(matrix[c, 0] < matrix[r, 0]) {
                    int[] swap = new int[2];
                    swap[0] = matrix[c, 0];
                    swap[1] = matrix[c, 1];
                    
                    matrix[c, 0] = matrix[r, 0];
                    matrix[c, 1] = matrix[r, 1];
                    
                    matrix[r, 0] = swap[0];
                    matrix[r, 1] = swap[1];
                }
            }
        }
    }
}