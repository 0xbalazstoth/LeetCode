public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n.ToString() == "")
            return false;
        else
        {
            for (int i = 0; i <= 99; i++)
            {
                double pow = Math.Pow(2, i);
                if (pow == n)
                    return true;
            }
            return false;
        }
    }
}