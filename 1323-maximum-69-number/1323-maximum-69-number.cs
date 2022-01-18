public class Solution {
    public int Maximum69Number (int num) {
        var charArr = num.ToString().ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            if (charArr[i] == '6')
            {
                charArr[i] = '9';
                break;
            }
        }

        return int.Parse(new string(charArr));
    }
}