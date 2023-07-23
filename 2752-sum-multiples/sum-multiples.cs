public class Solution {
    public int SumOfMultiples(int n) {
        int sum = 0;
        int[] divs = new int[] { 3, 5, 7 };

        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 0;
        }

        // n = 7
        // [1, 2, 3, 4, 5, 6, 7] / 3, 5, 7 = [3, 5, 6, 7] -> 21
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < divs.Length; j++)
            {
                if (i % divs[j] == 0)
                {
                    sum += i;
                    break;
                }
            }
        }

        return sum;
    }
}