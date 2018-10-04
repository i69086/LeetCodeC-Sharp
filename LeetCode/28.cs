using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//实现 strStr() 函数。
//给定一个 haystack 字符串和一个 needle 字符串，在 haystack 字符串中找出 needle 字符串出现的第一个位置(从0开始)。如果不存在，则返回  -1。
namespace LeetCode
{
    class _28
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == null || needle == null)
            {
                return 0;
            }
            if (haystack.Length < needle.Length) return -1;
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                int j = 0;
                for (j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;
                }
                if (j == needle.Length)
                    return i;
            }
            return -1;
        }
    }
}
