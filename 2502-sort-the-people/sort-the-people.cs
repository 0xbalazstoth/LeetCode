public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i + 1; j < heights.Length; j++)
            {
                if (heights[i] < heights[j])
                {
                    int temp = heights[i];
                    string tempName = names[i];

                    heights[i] = heights[j];
                    names[i] = names[j];

                    heights[j] = temp;
                    names[j] = tempName;
                }
            }
        }

        return names;
    }
}