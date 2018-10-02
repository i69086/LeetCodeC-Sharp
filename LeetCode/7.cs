using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 给定一个 32 位有符号整数，将整数中的数字进行反转。

//示例 1:

//输入: 123
//输出: 321
// 示例 2:

//输入: -123
//输出: -321
//示例 3:

//输入: 120
//输出: 21
//注意:

//假设我们的环境只能存储 32 位有符号整数，其数值范围是 [−231,  231 − 1]。根据这个假设，如果反转后的整数溢出，则返回 0。
/// </summary>
namespace LeetCode
{
    class _7
    {
        public static int Reverse(int x)
        {
            try
            {
                string strx = x.ToString();
            string result = "";
            int j = -1;
            if(x<0) {
                result += "-";
                j = 0;
            }
            for (int i = strx.Length-1; i > j; i--)
            {
                result += strx[i];
            }
                int res = Convert.ToInt32(result);
                return res;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
