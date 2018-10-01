using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _605
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int j = 0;

            for (int i = 0; i < flowerbed.Length-1; i++)
            {
                if (flowerbed[i] == 0)
                {
                if (flowerbed[i + 1] == 0)
                {
                        if (i == 0&&flowerbed[i+1]==0)
                        {
                            flowerbed[i] = 1;
                        }else if  ((i + 2 < flowerbed.Length - 1&&flowerbed[i + 2] == 0)||(i+1 == flowerbed.Length-1&&flowerbed[i+1]==0))
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
