using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 尚未完成
/// </summary>
namespace LeetCode
{
    class _628
    {
        public static int MaximumProduct(int[] nums)
        {
            int max = nums[0] * nums[1] * nums[2];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for(int j = 1; j < nums.Length - 1; j++)
                {
                    for(int k = 2; k < nums.Length; k++)
                    {
                        int temp = nums[i] * nums[j] * nums[k];
                        if (temp > max) max = temp;
                    }
                }
            }
            return max;
        }
    }
}
