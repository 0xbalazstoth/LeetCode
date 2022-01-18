using System.Linq;
public class Solution {
    public char FindTheDifference(string s, string t) {
       return (char)(s + t).Aggregate(0, (acc, x) => acc ^ x);
    }
}