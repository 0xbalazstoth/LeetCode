public class Solution {
    public int NumJewelsInStones(string J, string S) {
        return S.Count(c => J.Contains(c));
    }
}