public class Solution {
    public bool IsPalindrome(int x) {
        string numTo = x.ToString();
        char[] arr = numTo.ToArray();
        Array.Reverse(arr);
        string reversed = "";
        for (int i = 0; i < arr.Length; i++)
        {
            reversed += arr[i];
        }
        if (x.ToString() == reversed)
            return true;
        return false;
    }
}