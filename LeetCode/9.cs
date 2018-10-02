using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。

//示例 1:

//输入: 121
//输出: true
//示例 2:

//输入: -121
//输出: false
//解释: 从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
//示例 3:

//输入: 10
//输出: false
//解释: 从右向左读, 为 01 。因此它不是一个回文数。
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
