public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        int countMatches = 0;

        if (arr.Length != target.Length)
            return false;
        else if (arr.Length == target.Length)
        {
            target = target.OrderBy(x => x).ToArray();
            arr = arr.OrderBy(x => x).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (target[i] == arr[i])
                    countMatches++;
            }
        }
        return (countMatches == target.Length && countMatches == arr.Length) ? true : false;
    }
}