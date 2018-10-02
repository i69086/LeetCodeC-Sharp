using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

//    编写一个函数来查找字符串数组中的最长公共前缀。

//如果不存在公共前缀，返回空字符串 ""。

//示例 1:

//输入: ["flower","flow","flight"]
//输出: "fl"
//示例 2:

//输入: ["dog","racecar","car"]
//输出: ""
//解释: 输入不存在公共前缀。
//说明:

//所有输入只包含小写字母 a-z 。
    class _14
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            try
            {
                int i = 0;
                while (i >= 0)
                {
                    bool sign = true;
                    int j = 1;
                    for(j = 1; j < strs.Count(); j++)
                    {
                        if (strs[j - 1][i] != strs[j][i]) sign = false;
                    }
                    if (sign == true)
                    {
                        result += strs[j - 1][i];
                        i++;
                    } else
                    {
                        break;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}
