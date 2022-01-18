public class Solution {
    public int ThirdMax(int[] nums) {
        List<int> cleanedArr = nums.Distinct().ToList();
        if (cleanedArr.Count == 0)
            return 0;
        else if (cleanedArr.Count == 1)
            return cleanedArr[0];
        else if (cleanedArr.Count >= 2 && cleanedArr.Count < 3)
        {
            int max = cleanedArr[0];
            for (int i = 0; i < cleanedArr.Count; i++)
            {
                if (max < cleanedArr[i])
                    max = cleanedArr[i];
            }
            return max;
        }
        else
        {
            SortedDictionary<int, int> sorting = new SortedDictionary<int, int>();
            for (int i = 0; i < cleanedArr.Count; i++)
            {
                if (sorting.ContainsKey(cleanedArr[i]))
                    sorting[cleanedArr[i]]++;
                else
                    sorting[cleanedArr[i]] = 1;
            }
            var descSorting = sorting.Select(x => new { Number = x.Key, Count = x.Value }).OrderByDescending(x => x.Number).ToList();
            return descSorting[2].Number;
            }
    }
}