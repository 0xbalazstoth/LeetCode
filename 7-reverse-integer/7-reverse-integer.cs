using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;
public class Solution {
    public int Reverse(int x) {
        bool flag = true;
        if (x < 0)
        {
            flag = false;
            x = -x;
        }
        long y = 0;
        while (x > 0)
        {
            int tmp = x % 10;
            y = y * 10 + tmp;
            x = x / 10;
        }
        if (flag == false)
        {
            y = -y;
        }
        if (y < int.MinValue || y > int.MaxValue)
            return 0;
        return (int)y;
    }
}