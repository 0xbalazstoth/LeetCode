public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> res = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    res.Add(i.ToString().Replace(i.ToString(), "FizzBuzz"));
                else if (i % 3 == 0)
                    res.Add(i.ToString().Replace(i.ToString(), "Fizz"));
                else if (i % 5 == 0)
                    res.Add(i.ToString().Replace(i.ToString(), "Buzz"));
                else
                    res.Add(i.ToString());
            }
            return res;
    }
}