public class Solution {
    public bool JudgeCircle(string moves) {
        (int x, int y) start = (0, 0);
        foreach (var move in moves)
        {
            switch (move)
            {
                case 'R':
                    start.x++;
                    break;
                case 'L':
                    start.x--;
                    break;
                case 'U':
                    start.y--;
                    break;
                case 'D':
                    start.y++;
                    break;
            }
        }
        return start == (0, 0);
    }
}