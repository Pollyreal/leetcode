public partial class HashTableSolution
{
    /// <summary>
    /// 给定一个未排序的整数数组 nums ，找出数字连续的最长序列（不要求序列元素在原数组中连续）的长度。
    /// 请你设计并实现时间复杂度为 O(n) 的算法解决此问题。
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var res = 0;
        foreach (var num in nums)
        {
            if (!set.Contains(num - 1))
            {
                var cur = num;
                var curLen = 1;
                while (set.Contains(cur + 1))
                {
                    cur++;
                    curLen++;
                }

                res = Math.Max(res, curLen);
            }
        }

        return res;
    }
}