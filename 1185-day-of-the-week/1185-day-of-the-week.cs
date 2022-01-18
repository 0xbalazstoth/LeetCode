public class Solution {
    public string DayOfTheWeek(int day, int month, int year) {
        string dateString = $"{year}.{month}-{day}";
        var d = DateTime.Parse(dateString).DayOfWeek;
        return d.ToString();
    }
}