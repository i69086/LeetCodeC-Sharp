using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//两个整数之间的汉明距离指的是这两个数字对应二进制位不同的位置的数目。

//给出两个整数 x 和 y，计算它们之间的汉明距离
namespace LeetCode
{
    class _461
    {
        public static int HammingDistance(int x, int y)
        {
            string x1 = Convert.ToString(x, 2);
            string x2 = Convert.ToString(y, 2);
            int len = Math.Abs(x1.Length - x2.Length);
            if (len > 0 && x1.Length < x2.Length)
            {
                for(int j = 0; j < len; j++)
                {
                    x1 = "0" + x1;
                }
            }else if (len > 0 && x1.Length > x2.Length)
            {
                for (int j = 0; j < len; j++)
                {
                    x2 = "0" + x2;
                }
            }
            int distance = 0;
            for(int i = 0; i < x1.Length; i++)
            {
                if (x1[i] != x2[i]) distance++;
            }
            return distance;
        }
    }
}
