public class Solution {
    public bool JudgeSquareSum(int c) {
        for (long a = 0; a * a <= c; a++) {
            double b = Math.Sqrt(c - a * a);
            if (b == (int)b)
                return true;
        }
        return false;
    }
}