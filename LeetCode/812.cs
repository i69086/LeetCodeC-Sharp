using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 给定包含多个点的集合，从其中取三个点组成三角形，返回能组成的最大三角形的面积。
//示例:
//输入: points = [[0,0],[0,1],[1,0],[0,2],[2,0]]
//输出: 2
/// </summary>
namespace LeetCode
{
    class _812
    {
        public double LargestTriangleArea()
        {

            var points = new int[1][];
            double area = 0; double maxArea = 0;
            for(int i = 0; i < points.Length; i++)
            {
                for(int j = 0; j < points.Length; j++)
                {
                    for (int k = 0; k < points.Length; k++)
                    {
                        if (i == j || i == k || k == j)
                        {
                            continue;
                        }
                        double a = getEdge(points[i][0], points[i][1], points[j][0], points[j][1]);
                        double b = getEdge(points[j][0], points[j][1], points[k][0], points[k][1]);
                        double c = getEdge(points[k][0], points[k][1], points[i][0], points[i][1]);
                        area = (1 / 4) * Math.Sqrt((a + b + c) * (a + b - c) * (a + c - b) * (b + c - a));
                        if (area > maxArea) maxArea = area;
                    }
                }
            }
            return maxArea;
        }

        public double getEdge(int a,int b, int x, int y)
        {
            return Math.Sqrt(Math.Pow(a + x, 2) + Math.Pow((b + y), 2));
        }
    }
}
