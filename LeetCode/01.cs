﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//给定一个整数数组和一个目标值，找出数组中和为目标值的两个数。

//你可以假设每个输入只对应一种答案，且同样的元素不能被重复利用。

//示例:

//给定 nums = [2, 7, 11, 15], target = 9

//因为 nums[0] + nums[1] = 2 + 7 = 9
//所以返回[0, 1]
    class _01
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                for (int j = 1; j < nums.Length; j++)
                {
                    if(nums[j] + nums[i]==target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0,0};
        }
    }
}
