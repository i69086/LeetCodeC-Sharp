﻿using System;
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
    class Program
    {
        static void Main(string[] args)
        {
            //_01.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            //var res = _605.CanPlaceFlowers(new int[] { 0,0,1,0,1 }, 2);
            //var max = _628.MaximumProduct(new int[] {-1,-2,1,2,3 });
            //Console.WriteLine(_7.Reverse(1534236469));
            Console.WriteLine(_9.IsPalindrome(121));
        }
    }
}
