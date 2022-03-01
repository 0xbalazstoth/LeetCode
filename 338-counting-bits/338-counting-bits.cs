public class Solution {
    public int[] CountBits(int n) {
        int[] a = new int[n + 1];
        for (int i = 0; i < n + 1; i++)
        {
            string bin = Convert.ToString(i, 2);
            int bits = bin.Where(x => x == '1').Count();
            a[i] = bits;
        }
        
        return a;
    }
}