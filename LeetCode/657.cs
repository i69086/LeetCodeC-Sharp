using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//在二维平面上，有一个机器人从原点(0, 0) 开始。给出它的移动顺序，判断这个机器人在完成移动后是否在(0, 0) 处结束。

//移动顺序由字符串表示。字符 move[i] 表示其第 i 次移动。机器人的有效动作有 R（右），L（左），U（上）和 D（下）。如果机器人在完成所有动作后返回原点，则返回 true。否则，返回 false。
namespace LeetCode
{
    class _657
    {
        public static bool JudgeCircle(string moves)
        {
            int position = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                char a = moves[i];
                if (moves[i].ToString() == "U")
                {
                    position += 10;//向上+10
                }
                else if (moves[i].ToString() == "D")
                {
                    position -= 10;//向下-10
                }
                else if (moves[i].ToString() == "L")
                {
                    position -= 1;//向左-1
                }
                else if (moves[i].ToString() == "R")
                {
                    position += 1;//向右+1
                }
            }
            if (position == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
