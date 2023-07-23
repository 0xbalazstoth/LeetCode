public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] decoded = new int[encoded.Length + 1];
        int n = decoded.Length;

        decoded[0] = first; // 1
        // arr[0] ^ encoded[0] = 1 ^ 1 -> 0
        // arr[1] ^ encoded[1] = 0 ^ 2 -> 2
        // arr[2] ^ encoded[2] = 2 ^ 3 -> 1
        
        for (int i = 1; i < n; i++)
        {
            decoded[i] = decoded[i - 1] ^ encoded[i - 1];
        }
        
        return decoded;
    }
}