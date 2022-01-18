/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int low = 0;
        int high = n;

        while(low < high)
        {
            int center = low + (high - low)/2;
            if(IsBadVersion(center))
            {
                high = center;
            }
            else
            {
                low = center + 1;
            }
        }

        return low;
    }
}