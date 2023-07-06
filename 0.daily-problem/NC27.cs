using System;
using System.Collections.Generic;

// NC27 集合的所有子集(一)
// 复杂度太高，需用位运算优化
partial class Solution
{
    /**
     * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
     *
     * 
     * @param S int整型一维数组 
     * @return int整型二维数组
     */
    public List<List<int>> subsets(List<int> S)
    {
        // write code here
        var res = new List<List<int>>();
        for (int i = 0; i < S.Count(); i++)
        {
            for (int j = 0; j < i; j++)
            {
                res.Add(S.Take(new Range(j, j + i)).ToList());
            }
        }
        return res;
    }
}