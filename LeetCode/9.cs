using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _9
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x < 10) return true;
            string strx = Convert.ToString(x);
            string result = "";
            for(int i = strx.Length-1; i > -1; i--)
            {
                result += strx[i];
            }
            if (Convert.ToInt64(result) == x) return true;
            return false;
        }
    }
}
