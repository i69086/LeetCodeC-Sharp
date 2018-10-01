using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//假设你有一个很长的花坛，一部分地块种植了花，另一部分却没有。可是，花卉不能种植在相邻的地块上，它们会争夺水源，两者都会死去。

//给定一个花坛（表示为一个数组包含0和1，其中0表示没种植花，1表示种植了花），和一个数 n 。能否在不打破种植规则的情况下种入 n 朵花？能则返回True，不能则返回False。
    class _605
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int j = 0;
            if (flowerbed.Length == 1 && flowerbed[0] == 0) return true;
            for (int i = 0; i<flowerbed.Length-1; i++)
            {
                if (flowerbed[i] == 0)
                {
                if (flowerbed[i + 1] == 0)
                {
                        if (i == 0&&flowerbed[i + 1]==0)
                        {
                            flowerbed[i] = 1; j++;
                        }else if  ((i + 2 < flowerbed.Length - 1&&flowerbed[i + 2] == 0)||(i+1 == flowerbed.Length-1&&flowerbed[i + 1]==0))
                        {
                            flowerbed[i + 1] = 1;
                            i += 1;
                            j++;
                        }
                }
            }
        }
        if (j >= n) return true; else return false;
        }
    }
}
