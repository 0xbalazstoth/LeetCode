public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] decoded = new int[encoded.Length + 1];
        int n = decoded.Length;

        decoded[0] = first;
        
        for (int i = 1; i < n; i++)
        {
            decoded[i] = decoded[i - 1] ^ encoded[i - 1];
        }
        
        return decoded;
    }
}